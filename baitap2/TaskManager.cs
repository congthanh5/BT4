

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(string taskName)
    {
        Task newTask = new Task { Name = taskName };
        newTask.StateChanged += HandleTaskStateChanged;
        tasks.Add(newTask);
        Console.WriteLine($"Công việc '{taskName}' đã được thêm vào danh sách.");
    }

    public void DisplayTasks(bool completed)
    {
        Console.WriteLine($"Danh sách công việc {(completed ? "đã hoàn thành" : "chưa hoàn thành")}:");
        foreach (var task in tasks)
        {
            if (task.Completed == completed)
            {
                Console.WriteLine($"{task.Name} - {(task.Completed ? "Đã hoàn thành" : "Chưa hoàn thành")}");
            }
        }
    }

    public void MarkTaskCompleted(string taskName, bool completed)
    {
        Task taskToMark = tasks.Find(t => t.Name.Equals(taskName, StringComparison.OrdinalIgnoreCase));
        if (taskToMark != null)
        {
            taskToMark.Completed = completed;
        }
    }

    private void HandleTaskStateChanged(object sender, TaskEventArgs e)
    {
        Console.WriteLine($"Trạng thái công việc '{e.TaskName}' đã thay đổi thành {(e.Completed ? "Đã hoàn thành" : "Chưa hoàn thành")}");
    }
}
