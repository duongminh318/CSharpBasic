//Collection - List<T>
using System.Collections;

List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Add(4);
Console.WriteLine(string.Join(", ", numbers));

//Dictionary<TKey, TValue>
Dictionary<string, int> studentScores =  new Dictionary<string, int>()
{
    { "Alice", 90 },
    { "Bob", 85 }
};
Console.WriteLine(studentScores["Alice"]);

//ArrayList
ArrayList list = new ArrayList() { 1, "Hello", true };
list.Add(3.14);
Console.WriteLine(string.Join(", ",list.Cast<object>()));

//Hastable
Hashtable students = new Hashtable()
{
    { "Alice", 90 },
    { "Bob", 85 }
};
Console.WriteLine(students["Alice"]);