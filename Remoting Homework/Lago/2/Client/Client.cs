using System;
using System.Runtime.Remoting;

class Client
{
  static void Main(string[] args)
  {
    RemotingConfiguration.Configure("Client.exe.config", false);
    InventoryManager obj = new InventoryManager();
    obj.UpdateInventory("teste", 10);
    Console.WriteLine("Client done. Press enter.");
    Console.ReadLine();
  }
}
