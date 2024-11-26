//Where
var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
var evenNumbers = numbers.Where(n => n % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

//Select
var names = new List<string>() { "Alice", "Bob", "Charlie", "Anna" };
var upperNames = names.Select(n => n.ToUpper());
foreach (var name in upperNames)
{
    Console.WriteLine(name);
}

//OrderBy and OrderByDescending
var unOrderedNumbers = new List<int>() { 5, 3, 8, 1 };
var sortedNumbers = unOrderedNumbers.OrderBy(n => n);
foreach (var number in sortedNumbers)
{
    Console.WriteLine(number);
}

//GroupBy
var groupedStudents = names.GroupBy(n => n[0]);
foreach (var group in groupedStudents)
{
    Console.WriteLine($"Key: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine(student);
    }
}

//First, FirstOrDefault, Last, LastOrDefault
Console.WriteLine(numbers.First());
Console.WriteLine(numbers.Last());
Console.WriteLine(numbers.FirstOrDefault(n => n > 5));

//Aggregate
var sum = numbers.Aggregate((total, next) => total + next);
Console.WriteLine(sum);

//Search
var products = new List<string>() { "Apple", "Banana", "Cherry" };
var searchResult = products.Where(p => p.Contains("a"));
foreach  (var product in searchResult)
{
    Console.WriteLine(product);
}

//Paging
var items = Enumerable.Range(1, 20);
int pageSize = 5;
int page = 1;
var pagedItems = items.Skip((page - 1) * pageSize).Take(pageSize);
foreach  (var item in pagedItems)
{
    Console.WriteLine(item);
}