using System;
using System.Threading;

public class App {
    


    public static void Main(string[] args) {
        Tasks tasks = new Tasks();
        SubTasks s = new SubTasks(tasks);

        int i = 20;
        while(i-- >= 0) {
            tasks.Warn();
            Thread.Sleep(1000);
        }
    }
}