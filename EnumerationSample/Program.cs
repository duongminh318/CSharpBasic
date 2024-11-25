using EnumerationSample;
using System.ComponentModel;

DayOfWeek today = DayOfWeek.Monday;
Console.WriteLine(today);
int dayValue = (int)DayOfWeek.Monday;
Console.WriteLine(dayValue);
DayOfWeek day = (DayOfWeek)3;
Console.WriteLine(day);

foreach(DayOfWeek dow in Enum.GetValues(typeof(DayOfWeek)))
{
    Console.WriteLine(dow);
}

Console.WriteLine("Enter number from 1 - 7:");
int dayNumber = int.Parse(Console.ReadLine());
if(Enum.IsDefined(typeof(DayOfWeek), dayNumber))
{
    DayOfWeek day1 = (DayOfWeek)dayNumber;
    Console.WriteLine(day1);
}
else
{
    Console.WriteLine("Invalid number");
}
var descriptions = EnumHelper.GetEnumDescriptions<DayOfWeek>();
foreach(var desc in descriptions)
{
    Console.WriteLine(desc.Value + " " + desc.Name + " " + desc.Description);
}
enum DayOfWeek
{
    [Description("Thứ 2")]
    Monday = 1,
    [Description("Thứ 3")]
    Tuesday = 2,
    [Description("Thứ 4")]
    Wednesday = 3,
    [Description("Thứ 5")]
    Thursday = 4,
    [Description("Thứ 6")]
    Friday = 5,
    [Description("Thứ 7")]
    Saturday = 6,
    [Description("Chủ nhật")]
    Sunday = 7
}

