Console.WriteLine("Enter your birthday:");
string input = Console.ReadLine();

if(DateTime.TryParseExact(input,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime birthDate))
{
    var today = DateTime.Today;
    TimeSpan livedDays = today - birthDate;
    Console.WriteLine($"Total days you lived: {livedDays.Days} days");
}
else
{
    Console.WriteLine("Invalid birthdate, please enter format dd/MM/yyyy");
}