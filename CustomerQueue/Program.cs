Queue<string> customers = new Queue<string> ();
while (true)
{
    Console.WriteLine("\n1. Add new customer");
    Console.WriteLine("2. Call the next customer");
    Console.WriteLine("3. Show list customers");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Please choose a function:");
    int choice = int.Parse (Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter customer name:");
            customers.Enqueue(Console.ReadLine ());
            break;
        case 2:
            if (customers.Count > 0)
                Console.WriteLine($"Call customer: {customers.Dequeue()}");
            else
                Console.WriteLine("Customer queue is empty");
            break;
        case 3:
            Console.WriteLine("List customer in the queue:");
            foreach(string s in customers) 
                Console.WriteLine(s);
            break;
        case 0:
            return;
        default: 
            Console.WriteLine("Invalid choice");
            break;
    }
}