DateTime now = DateTime.Now;
Console.WriteLine($"Current time: {now}");

DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"Current UTC time: {utcNow}");

DateTime specificDate = new DateTime(2024, 11, 26, 14, 30, 0);
Console.WriteLine("Specific time: " + specificDate);

DateTime today = DateTime.Today;
Console.WriteLine("Today short date string: " + today.ToShortDateString());

Console.WriteLine("Default format: " + now.ToString());
Console.WriteLine("Day: " + now.ToShortDateString());
Console.WriteLine("Hour: " + now.ToShortTimeString());
Console.WriteLine("Custom: " + now.ToString("dd/MM/yyyy HH:mm:ss"));

string dateString = "26/11/2024 14:30";
DateTime parsedDate = DateTime.ParseExact(dateString, "dd/MM/yyyy HH:mm", null); 
Console.WriteLine("Date parsed: " + parsedDate);

DateTime tomorrow = now.AddDays(1);
DateTime lastWeek = now.AddDays(-7);
Console.WriteLine("Tomorrow: " + tomorrow);
Console.WriteLine("Last week: " + lastWeek);

Console.WriteLine("Year: " + now.Year);
Console.WriteLine("Month: " + now.Month);
Console.WriteLine("Day: " + now.Day);
Console.WriteLine("Hour: " + now.Hour);
Console.WriteLine("Minutes: " + now.Minute);
Console.WriteLine("Second: " + now.Second);

bool isValidDate = DateTime.TryParse("30/02/2024", out DateTime result); 
Console.WriteLine(isValidDate ? "Valid" : "Invalid");

//TimeSpan được sử dụng để biểu diễn khoảng cách giữa hai thời điểm:
DateTime start = new DateTime(2024, 11, 1);
DateTime end = new DateTime(2024, 11, 26);
TimeSpan duration = end - start;
Console.WriteLine("Number of days: " + duration.Days);

DateTime startTime = DateTime.Now;
// Một tác vụ mất thời gian
System.Threading.Thread.Sleep(2000);
DateTime endTime = DateTime.Now;
TimeSpan elapsedTime = endTime - startTime;
Console.WriteLine("Total processing time: " + elapsedTime.TotalSeconds + " seconds");

TimeZoneInfo vietnamZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamZone);
Console.WriteLine("VN Time: " + vietnamTime);
