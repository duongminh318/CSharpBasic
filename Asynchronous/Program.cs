using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bắt đầu.");

        // Gọi phương thức bất đồng bộ
        await Task.Delay(2000);  // Mô phỏng tác vụ tốn thời gian

        Console.WriteLine("Kết thúc sau 2 giây.");


        Console.WriteLine("Bắt đầu.");

        int result = await GetDataAsync(); // Lấy dữ liệu bất đồng bộ

        Console.WriteLine($"Kết quả nhận được: {result}");

    }


    static async Task<int> GetDataAsync()
    {
        // Mô phỏng lấy dữ liệu từ một nguồn bất đồng bộ
        await Task.Delay(2000);
        return 42;  // Giả sử 42 là dữ liệu chúng ta nhận được
    }
}
