interface IAnimal
{
    void Speak();
    void Move();
}

class Bird : IAnimal
{
    public void Move()
    {
        Console.WriteLine("Bird flies");
    }

    public void Speak()
    {
        Console.WriteLine("Bird chirps: Tweet tweet");
    }
}