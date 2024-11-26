while (true)
{
    Console.Clear();
    DateTime now = DateTime.Now;
    Console.WriteLine($"Current time: {now.ToString("HH:mm:ss")}");
    Thread.Sleep(1000);
}