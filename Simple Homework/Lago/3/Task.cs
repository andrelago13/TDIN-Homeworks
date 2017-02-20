using System;

public class Task {

    string desc;
    DateTime due;

    public string Description {
        get {
            return desc;
        }
    }

    public DateTime DueDate {
        get {
            return due;
        }
    }

    public Task(string desc, DateTime due) {
        this.desc = desc;
        this.due = due;
    }
}