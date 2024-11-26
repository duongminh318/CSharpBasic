var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

var evenNumbers = from number in numbers
                  where number % 2 == 0
                  select number;

var oddNumbers = from number in numbers
                 where number % 2 == 1
                 select number;

Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
Console.WriteLine($"Odd numbers: {string.Join(", ", oddNumbers)}");


string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
var longFruits = fruits.Where(f => f.Length > 5);

Console.WriteLine($"Fruits with more than 5 characters: {string.Join(", ", longFruits)}");


var doubleNumbers = numbers.Select(number => number * 2);
Console.WriteLine($"Doubled numbers: {string.Join(", ", doubleNumbers)}");