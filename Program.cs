// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to ToDo Task Manager!");
List<ToDoTask> toDoTasks = new List<ToDoTask>();

while (true)
{
    Console.WriteLine("Write a command");
    string command = Console.ReadLine() ?? "";
    switch (command)
    {
        case "create":
            Console.WriteLine("Write a task name:");
            string name = Console.ReadLine() ?? "";
            if (name.Length == 0)
            {
                Console.WriteLine("Task name connot be empty!");
                break;
            }
            ToDoTask task = new ToDoTask(name);
            toDoTasks.Add(task);
            Console.WriteLine("Task created!");
            break;
        case "update":
            Console.WriteLine("Write a task name:");
            string uName = Console.ReadLine() ?? "";
            if (uName.Length == 0)
            {
                Console.WriteLine("Task name connot be empty!");
                break;
            }
            ToDoTask uTask = toDoTasks.Find(t => t.Name == uName);
            if (uTask is null)
            {
                Console.WriteLine("Task not found!");
                break;
            }
            uTask.MarkIsDone();
            Console.WriteLine("Task status updated!");
            break;
        case "delete":
            Console.WriteLine("Write a task name:");
            string dName = Console.ReadLine() ?? "";
            if (dName.Length == 0)
            {
                Console.WriteLine("Task name connot be empty!");
                break;
            }
            var result = toDoTasks.Remove(toDoTasks.Find(t => t.Name == dName));
            if (!result)
                Console.WriteLine("Something bad happend when removing task!");
            Console.WriteLine("Task was removed!");
            break;
        case "showall":
            foreach (var item in toDoTasks)
            {
                item.Print();
            }
            break;
        case "exit":
            Console.WriteLine("good buy!");
            break;

        default:
            Console.WriteLine("Command is unknown");
            break;
    }

    if (command == "exit") break;
}

string[] GetCommands(string cmd)
{
    string[] commands = cmd.Split(" ");
    return commands;
}



