using System;
using System.Runtime.Remoting;

[Serializable]
public class Watcher : InventoryWatcher
{
  public static void Main(string[] args)
  {
    RemotingConfiguration.Configure("Watcher.exe.config", false);
    InventoryManager obj = new InventoryManager();
    Watcher w = new Watcher();
    obj.InventoryChangeEvent += w.Updated;
    Console.WriteLine("Watcher started. Press enter.");
    Console.ReadLine();
  }

  protected override void UpdatedCore(object sender, InventoryChangeArgs info) {
    Console.WriteLine(info.pno + " - " + info.change);
  }
}
