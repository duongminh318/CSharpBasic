DateTime today = DateTime.Now;
DateTime endOfYear = new DateTime(today.Year, 12, 31, 23, 59, 59);
TimeSpan timeRemaining = endOfYear  -  today;
Console.WriteLine($"Remaining {timeRemaining.Days} days, {timeRemaining.Hours}, {timeRemaining.Minutes}");