static double Add(double a, double b) => a + b;
static double Substract(double a, double b) => a - b;
static double Mutiply(double a, double b) => a * b;
static double Divide(double a, double b) => b != 0? a / b : 0;

MathOperation operation;

operation = Add;

Console.WriteLine($"Add: {operation(10, 5)}");
operation = Substract;
Console.WriteLine($"Add: {operation(10, 5)}");
operation = Mutiply;
Console.WriteLine($"Add: {operation(10, 5)}");
operation = Divide;
Console.WriteLine($"Add: {operation(10, 5)}");

delegate double MathOperation(double a, double b);