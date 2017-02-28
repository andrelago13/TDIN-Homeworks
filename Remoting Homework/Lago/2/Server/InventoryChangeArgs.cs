using System;

[Serializable]
public class InventoryChangeArgs {
    public string pno;
    public int change;

    public InventoryChangeArgs(string c_pno, int c_change) {
        pno = c_pno;
        change = c_change;
    }
}