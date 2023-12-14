using ProductLib;

namespace WinFormProductClient
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new();
        public Form1()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            cboCreateCat.DataSource = Enum.GetValues<Category>();
            cboUpdateCat.DataSource = Enum.GetValues<Category>();
            bs.DataSource = new List<ProductResponse>();
            dgvProducts.DataSource = bs;
            dgvProducts.Columns["Price"].DisplayIndex = dgvProducts.Columns.Count - 1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cbCreatePosi.DataSource = Enum.GetValues<Position>();
            cbCreatePosi.DataSource = Enum.GetValues<Position>();

            btnRefresh.Click += DoClickRefresh;

            btnCreateSubmit.Click += DoClickCreateSubmit;

            bs.PositionChanged += DoProductPositionChanged;

            btnUpdateSubmit.Click += DoClickUpdateSubmit;

            btnDelete.Click += DoClickDelete;

            btnCreateClear.Click += DoClickCreateClear;

            btnPricings.Click += DoClickPricings;

            btnCreateSClear.Click += DoClickSCreateClear;

            btnSdel.Click += DoClickSDelete;

            btnSRe.Click += DoClickSRefresh;

            btnCreateS.Click += DoClickSCreateSubmit;
        }

        private void DoClickPricings(object? sender, EventArgs e)
        {
            (new Form2(txtUpdateCode.Text)).ShowDialog();
        }

        private void DoClickCreateClear(object? sender, EventArgs e)
        {
            txtCreateCode.Clear();
            txtCreateName.Clear();
            cboCreateCat.SelectedItem = Category.None;

        }
        private void DoClickSCreateClear(object? sender, EventArgs e)
        {
            txtStaffid.Clear();
            txtSname.Clear();
            cbCreatePosi.SelectedItem = Position.None;

        }

        private async void DoClickDelete(object? sender, EventArgs e)
        {
            if (bs.Current == null) return;
            if (bs.Current is not ProductResponse prd) return;
            string endpoint = $"api/products/{prd.Id}";
            var result = await Program.RestClient.DeleteAsync<Result<string?>>(endpoint);
            if (result!.Succeded && prd.Id == result!.Data)
            {
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
            MessageBox.Show(result!.Message);
        }
        private async void DoClickSDelete(object? sender, EventArgs e)
        {
            if (bs.Current == null) return;
            if (bs.Current is not StaffResponse staff) return;
            string endpoint = $"api/staffs/{staff.Id}";
            var result = await Program.RestClient.DeleteAsync<Result<string?>>(endpoint);
            if (result!.Succeded && staff.Id == result!.Data)
            {
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
            MessageBox.Show(result!.Message);
        }

        private async void DoClickUpdateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/products";
            Category cat = ((Category)cboUpdateCat.SelectedItem);
            var req = new ProductUpdateReq()
            {
                Key = txtUpdateCode.Text,
                Name = txtUpdateName.Text,
                Category = cat == Category.None ? null : cat.ToString()
            };
            var cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            var result = await Program.RestClient.PutAsync<ProductUpdateReq, Result<string?>>(endpoint, req);
            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    if (double.TryParse(txtUpdatePrice.Text, out double price))
                    {
                        endpoint = "api/pricings";
                        //get all pricings
                        var allPricingsResult = await Program.RestClient.GetAsync<Result<List<PricingResponse>>>(endpoint);
                        PricingResponse? curPricingResponse = null;
                        if (allPricingsResult!.Succeded)
                        {
                            var allPricings = allPricingsResult.Data ?? new();
                            curPricingResponse = allPricings.Where(p => (p.ProductCode == req.Key) && ((p.EffectedFrom ?? DateTime.MinValue) <= DateTime.Now))
                                                            .OrderBy(p => p.EffectedFrom)
                                                            .LastOrDefault();
                        }
                        if (curPricingResponse == null)
                        {
                            var pricingReq = new PricingCreateReq()
                            {
                                ProductKey = req.Key,
                                EffectedFrom = DateTime.Now,
                                Value = price
                            };
                            var pricingResult = await Program.RestClient.PostAsync<PricingCreateReq, Result<string?>>(endpoint, pricingReq);
                        }
                        else
                        {
                            var pricingReq = new PricingUpdateReq()
                            {
                                Id = curPricingResponse!.Id ?? "",
                                ProductKey = result!.Data!,
                                Value = price
                            };
                            var pricingResult = await Program.RestClient.PutAsync<PricingUpdateReq, Result<string?>>(endpoint, pricingReq);
                        }



                    }

                    endpoint = $"api/Products/{result!.Data!}";
                    var foundResult = await Program.RestClient.GetAsync<Result<ProductResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        var found = (bs.DataSource as List<ProductResponse>)?.FirstOrDefault(b => b.Id == foundResult.Data.Id);
                        if (found != null)
                        {
                            found.Name = foundResult.Data.Name;
                            found.Category = foundResult.Data.Category;
                            found.Price = foundResult.Data.Price;
                            bs.ResetBindings(false);
                        }
                    }
                }
            });
            this.Cursor = cursor;
            MessageBox.Show(result!.Message);
            task.Wait();
        }

        private void DoProductPositionChanged(object? sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                txtUpdateCode.Clear();
                txtUpdateName.Clear();
                cboUpdateCat.SelectedItem = Category.None;
            }
            else
            {
                if (bs.Current is ProductResponse prd)
                {
                    txtUpdateCode.Text = prd.Code.ToString();
                    txtUpdateName.Text = prd.Name;
                    Category cat = Category.None;
                    Enum.TryParse<Category>(prd.Category ?? "", out cat);
                    cboUpdateCat.SelectedItem = cat;
                    txtUpdatePrice.Text = prd.Price?.ToString();
                }
            }
        }

        private async void DoClickCreateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/Products";
            Category cat = ((Category)cboCreateCat.SelectedItem);
            var req = new ProductCreateReq()
            {
                Code = txtCreateCode.Text,
                Name = txtCreateName.Text,
                Category = cat == Category.None ? null : cat.ToString()
            };
            var cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            var result = await Program.RestClient.PostAsync<ProductCreateReq, Result<string?>>(endpoint, req);

            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    if (double.TryParse(txtCreatePrice.Text, out double price))
                    {
                        var pricingReq = new PricingCreateReq()
                        {
                            ProductKey = req.Code,
                            Value = price,
                            EffectedFrom = DateTime.Now,
                        };
                        endpoint = "api/pricings";
                        var pricingResult = await Program.RestClient.PostAsync<PricingCreateReq, Result<string?>>(endpoint, pricingReq);
                    }
                    endpoint = $"api/Products/{result!.Data}";
                    var foundResult = await Program.RestClient.GetAsync<Result<ProductResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        (bs.DataSource as List<ProductResponse>)?.Add(foundResult.Data);
                        bs.ResetBindings(false);
                    }
                }
            });
            this.Cursor = cursor;
            MessageBox.Show(result!.Message);
            task.Wait();
        }
        private async void DoClickSCreateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/staffs";
            Position pos = ((Position)cbCreatePosi.SelectedItem);
            var req = new StaffCreateReq()
            {
                StaffKey = txtStaffid.Text,
                SName = txtSname.Text,
                Position = pos == Position.None ? null : pos.ToString()
            };
            var cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            var result = await Program.RestClient.PostAsync<StaffCreateReq, Result<string?>>(endpoint, req);

            Task task = Task.Run(async () =>
            {


                endpoint = $"api/staffs/{result!.Data}";
                var foundResult = await Program.RestClient.GetAsync<Result<StaffResponse?>>(endpoint);
                if (foundResult!.Succeded && foundResult.Data != null)
                {
                    (bs.DataSource as List<StaffResponse>)?.Add(foundResult.Data);
                    bs.ResetBindings(false);
                }

            });
            this.Cursor = cursor;
            MessageBox.Show(result!.Message);
            task.Wait();
        }

        private async void DoClickRefresh(object? sender, EventArgs e)
        {
            string endpoint = "api/Products";
            var result = await Program.RestClient.GetAsync<Result<List<ProductResponse>>>(endpoint);
            if (result!.Succeded == true)
            {
                bs.DataSource = result.Data;
                bs.ResetBindings(false);
            }
        }

        private async void DoClickSRefresh(object? sender, EventArgs e)
        {
            string endpoint = "api/staffs";
            var result = await Program.RestClient.GetAsync<Result<List<StaffResponse>>>(endpoint);
            if (result!.Succeded == true)
            {
                bs.DataSource = result.Data;
                bs.ResetBindings(false);
            }
        }

        private void txtCreateCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateSubmit_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}