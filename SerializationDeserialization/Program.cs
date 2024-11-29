using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable] // Đánh dấu lớp có thể tuần tự hóa
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Tạo đối tượng
        Person person = new Person() { Name = "Alice", Age = 30 };

        // Serialize đối tượng thành file nhị phân
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        IFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        using (Stream stream = new FileStream("person.dat", FileMode.Create, FileAccess.Write))
        {
            formatter.Serialize(stream, person);
        }

        // Deserialize đối tượng từ file nhị phân
        using (Stream stream = new FileStream("person.dat", FileMode.Open, FileAccess.Read))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}
