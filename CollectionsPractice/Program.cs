//Bài 1:

using System.Collections;
using System.Diagnostics;

Console.WriteLine("Practice 1:");
List<string> students = new List<string>() { "Alice", "Bob", "Mary" };

students.Add("David");
Console.WriteLine("List students after add:");
Console.WriteLine(string.Join(", ", students));

students.Remove("Bob");

Console.WriteLine("List students after remove:");

Console.WriteLine(string.Join(", ", students));

string searchName = "Mary";
if (students.Contains(searchName))
{
    Console.WriteLine($"Found name: {searchName}");
}
else
{
    Console.WriteLine($"Cannot found name: {searchName}");
}

Console.WriteLine("Practice 2:");

//Bài 2:
Dictionary<string, int> studentScores = new Dictionary<string, int>()
{
    { "Alice", 9 },
    { "Bob", 7 },
    { "Charlie", 8 },
    { "David", 10 }
};
Console.WriteLine("List students have mark greater than 8");
foreach (var student in studentScores)
{
    if(student.Value > 8)
    {
        Console.WriteLine($"{student.Key}: {student.Value}");
    }
}

//Bài 3:

Console.WriteLine("Practice 3:");

const int itemCount = 1000000;

ArrayList arrayList = new ArrayList();
for(int i = 0; i < itemCount; i++)
{
    arrayList.Add(i);
}

List<int> list = new List<int>();
for (int i = 0; i < itemCount; i++)
{
    list.Add(i);
}

Stopwatch sw = Stopwatch.StartNew();
foreach (int i in arrayList)
{
    int value = (int)i;
}
sw.Stop();
Console.WriteLine($"Time spend: {sw.ElapsedMilliseconds}");

sw.Restart();
foreach (int i in list)
{
    int value = i;
}
sw.Stop();
Console.WriteLine($"Time spend: {sw.ElapsedMilliseconds}");