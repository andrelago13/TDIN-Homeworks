using System;

public class InventoryManager: MarshalByRefObject
{
  [Serializable]
  public delegate void InventoryChangeHandler(object sender, InventoryChangeArgs info);

  public event InventoryChangeHandler InventoryChangeEvent;

  public InventoryManager() {
    Console.WriteLine("Constructor called");
  }

  public void UpdateInventory(string pno, int change) {
    if(InventoryChangeEvent != null) {
      Console.WriteLine("Updating...");
      InventoryChangeEvent(this, new InventoryChangeArgs(pno, change));
      Console.WriteLine("Updated.");
    } else {
      Console.WriteLine("NULL");
    }
  }

}
