using System;

public class InventoryManager: MarshalByRefObject
{
  public delegate void InventoryChangeHandler(object sender, InventoryChangeArgs info);

  public event InventoryChangeHandler InventoryChangeEvent;

  public void UpdateInventory(string pno, int change) {}

}
