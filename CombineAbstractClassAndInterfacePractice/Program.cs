List<Device> devices = new List<Device>()
{
    new SmartPhone("iPhone", "16 Pro Max"),
    new Laptop("Dell", "XPS 15")
};
foreach (var device in devices)
{
    device.GetDeviceInfo();
    if(device is INetworkConnectable connectable)
    {
        connectable.ConnectToNetwork();
    }
}    
abstract class Device
{
    public string Name { get; set; }
    public string Model { get; set; }

    public Device(string name, string model)
    {
        Name = name; Model = model;
    }

    public void GetDeviceInfo()
    {
        Console.WriteLine($"Device Name: {Name}, Model: {Model}");
    }
}

interface INetworkConnectable
{
    void ConnectToNetwork();
}

class SmartPhone : Device, INetworkConnectable
{
    public SmartPhone(string name, string model) : base(name, model)
    {
    }

    public void ConnectToNetwork()
    {
        Console.WriteLine($"{Name} (SmartPhone) is connected to the network");
    }
}

class Laptop : Device, INetworkConnectable
{
    public Laptop(string name, string model) : base(name, model)
    {
    }

    public void ConnectToNetwork()
    {
        Console.WriteLine($"{Name} (Laptop) is connected to the network");
    }
}