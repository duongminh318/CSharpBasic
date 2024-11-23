Vehicle vehicle = new Vehicle();
Car myCar = new Car();
Bike myBike = new Bike();

vehicle.Move();
myCar.Move();
myBike.Move(); 

class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("The vehicle is moving.");
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The car is driving on the road");
    }
}
class Bike : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The bike iss cycling on the track");
    }
}