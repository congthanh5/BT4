// File: Task.cs

using System;

public delegate void StateChangedEventHandler(object sender, TaskEventArgs e);

public class Task
{
    public string Name { get; set; }
    private bool completed;

    public bool Completed
    {
        get => completed;
        set
        {
            if (completed != value)
            {
                completed = value;
                OnStateChanged(new TaskEventArgs(Name, completed));
            }
        }
    }

    public event StateChangedEventHandler StateChanged;

    protected virtual void OnStateChanged(TaskEventArgs e)
    {
        StateChanged?.Invoke(this, e);
    }
}
