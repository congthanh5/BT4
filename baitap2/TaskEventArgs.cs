// File: TaskEventArgs.cs

using System;

public class TaskEventArgs : EventArgs
{
    public string TaskName { get; }
    public bool Completed { get; }

    public TaskEventArgs(string taskName, bool completed)
    {
        TaskName = taskName;
        Completed = completed;
    }
}
