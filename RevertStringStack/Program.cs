static string ReverseString(string value)
{
    //h,e,l,l,o
    Stack<char> chars = new Stack<char>();
    foreach (char c in value)
    {
        chars.Push(c);
    }
    string reversed = string.Empty;
    while (chars.Count > 0) { 
        reversed += chars.Pop();
    }
    return reversed;
}

Console.WriteLine("Input string:");
string input = Console.ReadLine();
string result = ReverseString(input);
Console.WriteLine($"Result: {result}");