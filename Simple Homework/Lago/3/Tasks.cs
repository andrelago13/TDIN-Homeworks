using System;

public class Tasks {

    Task[] tasks;

    public event TaskDue tasksEvent;

    public delegate void TaskDue(TaskEventArgs args);

    public Tasks() {
        tasks = new Task[3];
        tasks[0] = new Task("a", DateTime.Now + new TimeSpan(0, 0, 3));
        tasks[1] = new Task("b", DateTime.Now + new TimeSpan(0, 0, 5));
        tasks[2] = new Task("c", DateTime.Now + new TimeSpan(0, 0, 10));
    }

    public void Warn() {
        for(int i = 0; i < tasks.Length; ++i) {
            TimeSpan ts = tasks[i].DueDate - DateTime.Now;
            if(ts.Seconds < 1 && tasks[i].DueDate > DateTime.Now) {
                TaskEventArgs arg = new TaskEventArgs();
                arg.desc = tasks[i].Description;
                arg.toDueTime = tasks[i].DueDate - DateTime.Now;
                tasksEvent(arg);
            }
        }
    }

}