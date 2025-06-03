namespace Car_App;

public class Sedan : Car
{
    private int speed;
    public int Speed
    {
        get { return speed; }
        set
        {
            if (speed != value)
            {
                int oldSpeed = speed;
                speed = value;
                NotifyPropertyChanged("Speed", oldSpeed, value);
            }
        }
    }

    public Sedan(string brand, int speed) : base(brand)
    {
        this.speed = speed;
    }
}

