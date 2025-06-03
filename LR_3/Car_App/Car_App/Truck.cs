namespace Car_App;

public class Truck : Car
{
    private double loadCapacity;
    public double LoadCapacity
    {
        get { return loadCapacity; }
        set
        {
            if (loadCapacity != value)
            {
                double oldCapacity = loadCapacity;
                loadCapacity = value;
                NotifyPropertyChanged("LoadCapacity", oldCapacity, value);
            }
        }
    }

    public Truck(string brand, double loadCapacity) : base(brand)
    {
        this.loadCapacity = loadCapacity;
    }
}

