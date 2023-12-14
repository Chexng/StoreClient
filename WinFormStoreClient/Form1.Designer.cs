namespace WinFormProductClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            txtCreatePrice = new TextBox();
            label7 = new Label();
            btnCreateClear = new Button();
            cboCreateCat = new ComboBox();
            btnCreateSubmit = new Button();
            label3 = new Label();
            txtCreateName = new TextBox();
            label2 = new Label();
            txtCreateCode = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPricings = new Button();
            txtUpdatePrice = new TextBox();
            label8 = new Label();
            cboUpdateCat = new ComboBox();
            label4 = new Label();
            txtUpdateName = new TextBox();
            label5 = new Label();
            txtUpdateCode = new TextBox();
            label6 = new Label();
            btnUpdateSubmit = new Button();
            btnDelete = new Button();
            groupBox3 = new GroupBox();
            btnCreateSClear = new Button();
            cbCreatePosi = new ComboBox();
            btnCreateS = new Button();
            label10 = new Label();
            txtSname = new TextBox();
            label11 = new Label();
            txtStaffid = new TextBox();
            label12 = new Label();
            btnSdel = new Button();
            btnSRe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(16, 39);
            dgvProducts.Margin = new Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(631, 362);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(18, 7);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 22);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "View Product";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCreatePrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnCreateClear);
            groupBox1.Controls.Add(cboCreateCat);
            groupBox1.Controls.Add(btnCreateSubmit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCreateName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCreateCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(665, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(260, 172);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creating Products";
            // 
            // txtCreatePrice
            // 
            txtCreatePrice.Location = new Point(53, 119);
            txtCreatePrice.Margin = new Padding(3, 2, 3, 2);
            txtCreatePrice.Name = "txtCreatePrice";
            txtCreatePrice.Size = new Size(98, 23);
            txtCreatePrice.TabIndex = 10;
            txtCreatePrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 122);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "Price";
            // 
            // btnCreateClear
            // 
            btnCreateClear.Location = new Point(77, 146);
            btnCreateClear.Margin = new Padding(3, 2, 3, 2);
            btnCreateClear.Name = "btnCreateClear";
            btnCreateClear.Size = new Size(74, 21);
            btnCreateClear.TabIndex = 8;
            btnCreateClear.Text = "Clear";
            btnCreateClear.UseVisualStyleBackColor = true;
            // 
            // cboCreateCat
            // 
            cboCreateCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCreateCat.FormattingEnabled = true;
            cboCreateCat.Location = new Point(77, 86);
            cboCreateCat.Margin = new Padding(3, 2, 3, 2);
            cboCreateCat.Name = "cboCreateCat";
            cboCreateCat.Size = new Size(167, 23);
            cboCreateCat.TabIndex = 7;
            // 
            // btnCreateSubmit
            // 
            btnCreateSubmit.Location = new Point(161, 146);
            btnCreateSubmit.Margin = new Padding(3, 2, 3, 2);
            btnCreateSubmit.Name = "btnCreateSubmit";
            btnCreateSubmit.Size = new Size(82, 22);
            btnCreateSubmit.TabIndex = 6;
            btnCreateSubmit.Text = "Submit";
            btnCreateSubmit.UseVisualStyleBackColor = true;
            btnCreateSubmit.Click += btnCreateSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 87);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // txtCreateName
            // 
            txtCreateName.Location = new Point(53, 52);
            txtCreateName.Margin = new Padding(3, 2, 3, 2);
            txtCreateName.Name = "txtCreateName";
            txtCreateName.Size = new Size(190, 23);
            txtCreateName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtCreateCode
            // 
            txtCreateCode.Location = new Point(53, 20);
            txtCreateCode.Margin = new Padding(3, 2, 3, 2);
            txtCreateCode.Name = "txtCreateCode";
            txtCreateCode.Size = new Size(190, 23);
            txtCreateCode.TabIndex = 1;
            txtCreateCode.TextChanged += txtCreateCode_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPricings);
            groupBox2.Controls.Add(txtUpdatePrice);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cboUpdateCat);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtUpdateName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtUpdateCode);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnUpdateSubmit);
            groupBox2.Location = new Point(799, 216);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(260, 185);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Updating Products";
            // 
            // btnPricings
            // 
            btnPricings.Location = new Point(164, 119);
            btnPricings.Margin = new Padding(3, 2, 3, 2);
            btnPricings.Name = "btnPricings";
            btnPricings.Size = new Size(82, 22);
            btnPricings.TabIndex = 16;
            btnPricings.Text = "Pricings";
            btnPricings.UseVisualStyleBackColor = true;
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(56, 121);
            txtUpdatePrice.Margin = new Padding(3, 2, 3, 2);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(98, 23);
            txtUpdatePrice.TabIndex = 15;
            txtUpdatePrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 123);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 14;
            label8.Text = "Price";
            // 
            // cboUpdateCat
            // 
            cboUpdateCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUpdateCat.FormattingEnabled = true;
            cboUpdateCat.Location = new Point(80, 86);
            cboUpdateCat.Margin = new Padding(3, 2, 3, 2);
            cboUpdateCat.Name = "cboUpdateCat";
            cboUpdateCat.Size = new Size(167, 23);
            cboUpdateCat.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 88);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "Category";
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(56, 52);
            txtUpdateName.Margin = new Padding(3, 2, 3, 2);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(190, 23);
            txtUpdateName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 55);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Name";
            // 
            // txtUpdateCode
            // 
            txtUpdateCode.Location = new Point(56, 21);
            txtUpdateCode.Margin = new Padding(3, 2, 3, 2);
            txtUpdateCode.Name = "txtUpdateCode";
            txtUpdateCode.ReadOnly = true;
            txtUpdateCode.Size = new Size(190, 23);
            txtUpdateCode.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 23);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 8;
            label6.Text = "Code";
            // 
            // btnUpdateSubmit
            // 
            btnUpdateSubmit.Location = new Point(164, 148);
            btnUpdateSubmit.Margin = new Padding(3, 2, 3, 2);
            btnUpdateSubmit.Name = "btnUpdateSubmit";
            btnUpdateSubmit.Size = new Size(82, 22);
            btnUpdateSubmit.TabIndex = 6;
            btnUpdateSubmit.Text = "Submit";
            btnUpdateSubmit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(479, 415);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 22);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "ProductDelete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCreateSClear);
            groupBox3.Controls.Add(cbCreatePosi);
            groupBox3.Controls.Add(btnCreateS);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtSname);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtStaffid);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(941, 39);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(260, 172);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Creating Staffs";
            // 
            // btnCreateSClear
            // 
            btnCreateSClear.Location = new Point(44, 132);
            btnCreateSClear.Margin = new Padding(3, 2, 3, 2);
            btnCreateSClear.Name = "btnCreateSClear";
            btnCreateSClear.Size = new Size(74, 21);
            btnCreateSClear.TabIndex = 8;
            btnCreateSClear.Text = "Clear";
            btnCreateSClear.UseVisualStyleBackColor = true;
            // 
            // cbCreatePosi
            // 
            cbCreatePosi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCreatePosi.FormattingEnabled = true;
            cbCreatePosi.Location = new Point(77, 86);
            cbCreatePosi.Margin = new Padding(3, 2, 3, 2);
            cbCreatePosi.Name = "cbCreatePosi";
            cbCreatePosi.Size = new Size(167, 23);
            cbCreatePosi.TabIndex = 7;
            // 
            // btnCreateS
            // 
            btnCreateS.Location = new Point(144, 131);
            btnCreateS.Margin = new Padding(3, 2, 3, 2);
            btnCreateS.Name = "btnCreateS";
            btnCreateS.Size = new Size(82, 22);
            btnCreateS.TabIndex = 6;
            btnCreateS.Text = "Submit";
            btnCreateS.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 86);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 4;
            label10.Text = "Position";
            // 
            // txtSname
            // 
            txtSname.Location = new Point(53, 52);
            txtSname.Margin = new Padding(3, 2, 3, 2);
            txtSname.Name = "txtSname";
            txtSname.Size = new Size(190, 23);
            txtSname.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 53);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 2;
            label11.Text = "Name";
            // 
            // txtStaffid
            // 
            txtStaffid.Location = new Point(53, 20);
            txtStaffid.Margin = new Padding(3, 2, 3, 2);
            txtStaffid.Name = "txtStaffid";
            txtStaffid.Size = new Size(190, 23);
            txtStaffid.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 21);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 0;
            label12.Text = "Staff ID";
            // 
            // btnSdel
            // 
            btnSdel.Location = new Point(616, 415);
            btnSdel.Margin = new Padding(3, 2, 3, 2);
            btnSdel.Name = "btnSdel";
            btnSdel.Size = new Size(82, 22);
            btnSdel.TabIndex = 6;
            btnSdel.Text = "StaffDelete";
            btnSdel.UseVisualStyleBackColor = true;
            // 
            // btnSRe
            // 
            btnSRe.Location = new Point(142, 7);
            btnSRe.Margin = new Padding(3, 2, 3, 2);
            btnSRe.Name = "btnSRe";
            btnSRe.Size = new Size(96, 22);
            btnSRe.TabIndex = 7;
            btnSRe.Text = "View staff";
            btnSRe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 451);
            Controls.Add(btnSRe);
            Controls.Add(btnSdel);
            Controls.Add(groupBox3);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Store Form";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private Button btnCreateSubmit;
        private Label label3;
        private TextBox txtCreateName;
        private Label label2;
        private TextBox txtCreateCode;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnUpdateSubmit;
        private Button btnDelete;
        private Button btnCreateClear;
        private ComboBox cboCreateCat;
        private ComboBox cboUpdateCat;
        private Label label4;
        private TextBox txtUpdateName;
        private Label label5;
        private TextBox txtUpdateCode;
        private Label label6;
        private TextBox txtCreatePrice;
        private Label label7;
        private TextBox txtUpdatePrice;
        private Label label8;
        private Button btnPricings;
        private GroupBox groupBox3;
        private Button btnCreateSClear;
        private ComboBox cbCreatePosi;
        private Button btnCreateS;
        private Label label10;
        private TextBox txtSname;
        private Label label11;
        private TextBox txtStaffid;
        private Label label12;
        private Button btnSdel;
        private Button btnSRe;
    }
}