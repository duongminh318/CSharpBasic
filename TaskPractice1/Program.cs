class Program
{
    static async Task Main()
    {
        string[] urls = new[]
        {
            "https://jsonplaceholder.typicode.com/posts/1",
            "https://jsonplaceholder.typicode.com/posts/2",
            "https://jsonplaceholder.typicode.com/posts/3"
        };

        Console.WriteLine("Start downloading files...");

        await DownloadFileAsync(urls);

        Console.WriteLine("Finish download...");
    }

    static async Task DownloadFileAsync(string[] urls)
    {
        using HttpClient client = new HttpClient();
        Task[] downloadTasks = new Task[urls.Length];
        for (int i = 0; i < urls.Length; i++)
        {
            int index = i;
            downloadTasks[index] = Task.Run(async () =>
            {
                string content = await client.GetStringAsync(urls[index]);
                string fileName = $"File_{index + 1}.txt";
                await File.WriteAllTextAsync(fileName, content);
                Console.WriteLine($"Saved {fileName}");
            });
        }
        await Task.WhenAll(downloadTasks);
    }
}