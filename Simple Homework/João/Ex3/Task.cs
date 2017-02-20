using System;

public class Task {
    public string desc { get; }

    public DateTime dueDate { get; }

    public Task(string desc, DateTime dueDate) {
        this.desc = desc;
        this.dueDate = dueDate;
    }
}