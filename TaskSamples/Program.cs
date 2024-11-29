using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bắt đầu thực hiện...");

        // Gọi hàm bất đồng bộ
        await PerformAsyncTask();

        Console.WriteLine("Hoàn tất!");

        Console.WriteLine("Tính toán đang thực hiện...");
        int result = await CalculateSumAsync(10, 20);
        Console.WriteLine($"Kết quả: {result}");
    }

    static async Task PerformAsyncTask()
    {
        await Task.Run(() =>
        {
            // Mô phỏng tác vụ nặng
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Đang xử lý {i + 1}/5...");
                Task.Delay(1000).Wait(); // Chờ 1 giây
            }
        });
    }

    static async Task<int> CalculateSumAsync(int a, int b)
    {
        return await Task.Run(() =>
        {
            Task.Delay(2000).Wait(); // Mô phỏng độ trễ
            return a + b;
        });
    }
    static async Task DownloadFileAsync(string url)
    {
        Console.WriteLine($"Bắt đầu tải {url}...");
        await Task.Delay(3000); // Giả lập tải file
        Console.WriteLine($"Hoàn tất tải {url}");
    }
}
