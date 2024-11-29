using System;
using System.Text.Json;
using System.Xml.Serialization;

public class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }



    static void Main()
    {
        //JSON
        string jsonString = "{\"Name\":\"John\", \"Age\":30}";

        // Deserialize JSON thành đối tượng Person
        Person person = JsonSerializer.Deserialize<Person>(jsonString);

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        string jsonString1 = JsonSerializer.Serialize(person);

        Console.WriteLine(jsonString1);

        File.WriteAllText("person.json", jsonString1);

        var jsonString2 = File.ReadAllText("person.json");
        Person person1 = JsonSerializer.Deserialize<Person>(jsonString2);
        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");

        //XML

        string xmlString = "<Person><Name>John</Name><Age>30</Age></Person>";

        // Deserialize XML thành đối tượng Person
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (StringReader reader = new StringReader(xmlString))
        {
            Person personXml = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {personXml.Name}, Age: {personXml.Age}");
        }

        using (StringWriter writer = new StringWriter())
        {
            // Serialize đối tượng thành XML
            serializer.Serialize(writer, person);
            Console.WriteLine(writer.ToString());
        }

        using (FileStream fs = new FileStream("person.xml", FileMode.Create))
        {
            // Serialize đối tượng thành XML và ghi ra file
            serializer.Serialize(fs, person);
        }

        using (FileStream fs = new FileStream("person.xml", FileMode.Open))
        {
            // Deserialize từ file XML thành đối tượng Person
            Person personXml = (Person)serializer.Deserialize(fs);
            Console.WriteLine($"Name: {personXml.Name}, Age: {personXml.Age}");
        }


    }
}
