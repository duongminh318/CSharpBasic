int number = 0;
int? number1 = null;

int? age = null;
int defaultAges = age ?? 18;
int defaultAges1 = age ?? 18;
if (age.HasValue)
{
    Console.WriteLine($"Age: {age.Value}");
}
else
{
    Console.WriteLine("Age is not assigned value");
}
