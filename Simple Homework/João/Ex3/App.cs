using System.Threading;

public class App {
    public static void Main(string[] args) {
        Tasks tasks = new Tasks();
        SubTasks subTasks = new SubTasks(tasks);
        while(true) {
            Thread.Sleep(1000);
            tasks.Warn();
        }
    }
}