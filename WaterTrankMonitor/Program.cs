// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class WaterTankMonitor
{

    private WaterTank tank;

    public WaterTankMonitor(WaterTank tank)
    {
        this.tank = tank;
    }

    public void Empty()
    {
        lock (this)
        {
            while (tank.IsEmpty())
            {
                Monitor.Wait(this);
            }
            tank.SetEmpty(true);
            Monitor.PulseAll(this);
        }
    }

    public void Fill()
    {
        lock (this) 
        {
            while (!tank.IsEmpty())
            {
                Monitor.Wait(this);
            }
            tank.SetEmpty(false);
            Monitor.PulseAll(this);
        }
    }
}

public class WaterTank
{
    private bool empty = true;

    public virtual bool IsEmpty()
    {
        return empty;
    }

    public virtual void SetEmpty(bool b)
    {
        empty = b;
    }
}