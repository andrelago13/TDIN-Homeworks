using System;

public class SubTasks {

    public SubTasks(Tasks tasks) {
        tasks.tasksEvent += Handler;
    }

    public void Handler(TaskEventArgs arg) {
        Console.WriteLine("Task \"" + arg.desc + "\" is due (" + arg.toDueTime + ")");
    }

}