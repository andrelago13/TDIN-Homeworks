using System;

public class SubTasks {

    public SubTasks(Tasks tasks) {
        tasks.AddWarnListener(Handler);
    }

    public void Handler(string desc, TimeSpan time) {
        Console.WriteLine("[Warn] Task with description " + desc + " has a due time in " + time.TotalSeconds + " seconds!");
    }
}