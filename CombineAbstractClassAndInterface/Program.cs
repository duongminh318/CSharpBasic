Dolphin dolphin = new Dolphin();
dolphin.Speak();
dolphin.Eat();
dolphin.Swim();

abstract class Animal
{
    public abstract void Speak();
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

interface ISwimmable
{
    void Swim();
}

class Dolphin : Animal, ISwimmable
{
    public override void Speak()
    {
        Console.WriteLine("Dolphin clicks: Click click");
    }

    public void Swim()
    {
        Console.WriteLine("Dolphin swims in the ocean");
    }
}