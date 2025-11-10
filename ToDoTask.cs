public class ToDoTask : IToDoTask
{
    public string Name { get; set; }
    public bool IsDone { get; set; } = false;

    public ToDoTask(string name)
    {
        Name = name;
    }
    public void MarkIsDone()
    {
        IsDone = true;
    }

    public void Print()
    {
        string status = IsDone ? "Done" : "Not Done";
        Console.WriteLine($"Task: {Name}, Status: {status}");
    }
}