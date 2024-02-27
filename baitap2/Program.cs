// File: Program.cs

using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        taskManager.AddTask("Viết bài");
        taskManager.AddTask("Làm bài tập lập trình");
        taskManager.AddTask("Đọc sách");

        taskManager.DisplayTasks(false);

        taskManager.MarkTaskCompleted("Viết bài", true);

        taskManager.DisplayTasks(true);

        Console.ReadLine();
    }
}
