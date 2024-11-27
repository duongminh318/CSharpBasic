class Program
{
    //Step 1: Declare Event
    public event EventHandler<CustomEventArgs> MyEvent;

    public void TriggerEvent(string message)
    {
        MyEvent?.Invoke(this, new CustomEventArgs() { Message = message });
    }

    static void Main()
    {
        Program program = new Program();
        //Step 2: Assign event to method
        program.MyEvent += Program_MyEvent;

        //Call event
        program.TriggerEvent("Hello, this is a custom event argurments");
    }



    static void Program_MyEvent(object sender, CustomEventArgs e)
    {
        Console.WriteLine($"Event is triggered: {e.Message}");
    }
}

class CustomEventArgs : EventArgs
{
    public string Message { set; get; }
}