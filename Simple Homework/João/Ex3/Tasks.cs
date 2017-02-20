using System;

public class Tasks {
    public delegate void TaskEventArgs(string desc, TimeSpan time);

    private event TaskEventArgs warnEventListeners;

    private Task[] tasks;

    public Tasks() {
        tasks = new Task[3];
        tasks[0] = new Task("First task", DateTime.Now.AddSeconds(3));
        tasks[1] = new Task("Second task", DateTime.Now.AddSeconds(5));
        tasks[2] = new Task("Third task", DateTime.Now.AddSeconds(10));
    }

    public void Warn() {
        foreach (Task task in tasks) {
            TimeSpan timeLeft = task.dueDate.Subtract(DateTime.Now);
            if(timeLeft.TotalSeconds > 1 || timeLeft.TotalSeconds < 0)
                continue;
            if(warnEventListeners != null)
                warnEventListeners(task.desc, timeLeft);
        }
    }

    public void AddWarnListener(TaskEventArgs listener) {
        warnEventListeners += listener;
    }
}