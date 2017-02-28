using System;

[Serializable]
public abstract class InventoryWatcher : MarshalByRefObject
{
    public void Updated( object sender, InventoryChangeArgs e ) {
          UpdatedCore (sender, e);
    }

    protected abstract void UpdatedCore( object sender, InventoryChangeArgs e );

    public override object InitializeLifetimeService() {
         return null;
    }
}