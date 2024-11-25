Console.WriteLine("Enter radius:");
double radius = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"Area of circle with radius: {radius} is {area}");