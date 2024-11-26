
ShowMessage display = new ShowMessage(Console.WriteLine);

ShowMessage show = delegate (string message)
{
    Console.WriteLine(message);
};
ShowMessage show1 = (message) => Console.WriteLine("Lambda: " + message);

display("Hello, Delegate");
show("Hello, Anonymous");
show1("Hello Lambda");

public delegate void ShowMessage(string message);
