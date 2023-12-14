using MenuLib;
using ProductLib;
using RestClientLib;

namespace ProductClient;
public static class StaffHelper
{
    public static string BaseUrl { get; set; } = "https://localhost:5001";

    public static MenuBank MenuBank { get; set; } = new MenuBank()
    {
        Title = "Staffs",
        Menus = new List<Menu>()
        {
            new Menu(){ Text= "Viewing", Action=ViewingStaffs},
            new Menu(){ Text= "Creating", Action=CreatingStaffs},
            new Menu(){ Text= "Updating", Action=UpdatingStaffs},
            new Menu(){ Text= "Deleting", Action=DeletingStaffs},
            new Menu(){ Text= "Returning", Action = ReturningBack}
        }
    };
    public static void ReturningBack()
        {
            Console.WriteLine("\n[Returning Back]");
            MenuBank.LoopBreak = true;
        }
    private static void DeletingStaffs()
    {
        Task.Run(async () =>
        {
            RestClient<Staff> restClient = new(BaseUrl);
            Console.WriteLine("\n[Deleting Staff]");
            while (true)
            {
                Console.Write("Staff Id/Code: ");
                var key = Console.ReadLine() ?? "";
                var endpoint = $"api/staffs/{key}";
                var result = await restClient.DeleteAsync<Result<string>>(endpoint);
                if (result!.Data != null)
                {
                    Console.WriteLine($"Successfully delete the product with id/code, {key}");
                }
                else
                {
                    Console.WriteLine($"Failed to delete a product with id/code, {key}");
                }

                if (WaitForEscPressed("ESC to stop or any key for more deleting ..."))
                {
                    break;
                }
            }
        }).Wait();
    }
    private static void UpdatingStaffs()
    {
        Task.Run(async () =>
        {
            RestClient<Staff> restClient = new(BaseUrl);
            Console.WriteLine("\n[Updating Staffs]");
            while (true)
            {
                Console.Write("Staff Id/Code(required): ");
                var key = Console.ReadLine() ?? "";
                var endpoint = "api/staffs";
                Console.Write("New Name (optional)  : ");
                var name = Console.ReadLine();

                Console.WriteLine($"Category available: {Enum.GetNames<Position>().Aggregate((a, b) => a + ", " + b)}");
                Console.Write("New Position: ");
                var position = Console.ReadLine();

                var result = await restClient.PutAsync<StaffUpdateReq, Result<string>>(endpoint, new StaffUpdateReq()
                {
                    Key = key,
                    SName = name,
                    Position = position
                });

                if (result!.Data !=null)
                {
                    Console.WriteLine($"Successfully update the product with id/code, {key}");
                }
                else
                {
                    Console.WriteLine($"Failed to update the product with id/code, {key}");
                }

                Console.WriteLine();
                if (WaitForEscPressed("ESC to stop or any key for more updating...")) break;
            }
        }).Wait();
    }
    private static bool WaitForEscPressed(string text)
    { 
        Console.Write(text);;
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Console.WriteLine(keyInfo.KeyChar);
        return keyInfo.Key == ConsoleKey.Escape;
    }
    private static void CreatingStaffs()
    {
        Task.Run(async () =>
        {
            RestClient<Staff> restClient = new(BaseUrl);
            Console.WriteLine("\n[Creating Staff]");
            var endpoint = "api/staffs";
            while (true)
            {
                var req = GetCreateStaff();
                if (req != null)
                {
                    var result = await restClient.PostAsync<StaffCreateReq, Result<string>>(endpoint, req);
                    var id = result!.Data;
                    if (!string.IsNullOrEmpty(id))
                        Console.WriteLine($"Successfully created a new product with id, {id}");
                    else
                        Console.WriteLine($"Failed to create a new product code, {req.StaffKey}");
                }

                Console.WriteLine();
                if (WaitForEscPressed("ESC to stop or any key for more creating...")) break;
            }
        }).Wait();
    }
    static StaffCreateReq? GetCreateStaff()
    {
        Console.WriteLine($"position available: {Enum.GetNames<Position>().Aggregate((a, b) => a + ", " + b)}");
        Console.Write("Staff(code/name/staff): ");
        string data = Console.ReadLine() ?? "";
        var dataParts = data.Split("/");
        if (dataParts.Length < 3)
        {
            Console.WriteLine("Invalid create staff data");
            return null;
        }
        var code = dataParts[0].Trim();
        var name = dataParts[1].Trim();
        var category = dataParts[2].Trim();
       
        return new StaffCreateReq() { StaffKey = code, SName = name, Position = category };

    }
    private static  void ViewingStaffs()
    {
        Task.Run(async () =>
        {
            RestClient<Staff> restClient = new(BaseUrl);
            Console.WriteLine("\n[Viewing Staffs]");
            var endpoint = "api/staffs";
            var result = await restClient.GetAsync<Result<List<StaffResponse>>>(endpoint) ?? new();
            var all = result!.Data??new();
            var count = all.Count;
            Console.WriteLine($"Staffs: {count}");
            if (count == 0) return;

            Console.WriteLine($"{"Id",-36} {"StaffCode",-10} {"SName",-30} {"Poisition",-20}");
            Console.WriteLine(new string('=', 36 + 1 + 10 + 1 + 30 + 1 + 20 + 1 + 5));
            foreach (var st in all)
            {
                Console.WriteLine($"{st.Id,-36} {st.StaffCode,-10} {st.SName,-30} {st.Position,-20} ");
            }
        }).Wait();
    }
}
