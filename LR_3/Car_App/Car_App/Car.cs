namespace Car_App;

using System;

public abstract class Car
{
    public event EventHandler<PropertyChangedExtendedEventArgs> PropertyChanged;

    protected void NotifyPropertyChanged<T>(string propertyName, T oldValue, T newValue)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedExtendedEventArgs(propertyName, oldValue, newValue));
    }

    private string brand;
    public string Brand
    {
        get { return brand; }
        set
        {
            if (brand != value)
            {
                string oldBrand = brand;
                brand = value;
                NotifyPropertyChanged("Brand", oldBrand, value);
            }
        }
    }

    protected Car(string brand)
    {
        this.brand = brand;
    }
}

