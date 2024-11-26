List<int> numbers = new List<int> { 1, 2, 3,4,5,6,7,8,9,10 };

List<int> evenNumbers = numbers.FindAll(delegate(int number)
{
    return number % 2 == 0;
});

Console.WriteLine("Even numbers:");
evenNumbers.ForEach(num => Console.WriteLine(num));