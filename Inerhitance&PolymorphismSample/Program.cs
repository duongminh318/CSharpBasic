//Inheritance
var child = new Child();
child.Name = "John";
child.Display();
child.ShowMessage();
Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(3, 6));
Console.WriteLine(calculator.Add(2.5, 4.5));

Animal myDog = new Dog();
myDog.Speak();
class Parent
{
    public string Name { set; get; }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Child : Parent
{
    public void ShowMessage()
    {
        Console.WriteLine("This is a child class");
    }
}

//Polymorphism
//Overloading
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}
//Overriding
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal make a sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks");
    }
}