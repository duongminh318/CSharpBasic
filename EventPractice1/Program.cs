class TaskManager
{
    public event EventHandler<TaskEventArgs> TaskAdded;
    private List<string> _tasks = new List<string>();

    public void AddTask(string taskName)
    {
        _tasks.Add(taskName);
        TaskAdded?.Invoke(this, new TaskEventArgs() { TaskName = taskName });
    }
}
class TaskEventArgs : EventArgs
{
    public string TaskName { get; set; }
}

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        manager.TaskAdded += Manager_TaskAdded;

        manager.AddTask("Learning C# basic");
        manager.AddTask("Report project");
    }
    static void Manager_TaskAdded(object sender, TaskEventArgs e)
    {
        Console.WriteLine($"A new tasked added: {e.TaskName}");
    }
}