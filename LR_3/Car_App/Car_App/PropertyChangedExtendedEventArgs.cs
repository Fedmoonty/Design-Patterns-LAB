namespace Car_App;

using System;

public class PropertyChangedExtendedEventArgs : EventArgs
{
    public string PropertyName { get; }
    public object OldValue { get; }
    public object NewValue { get; }

    public PropertyChangedExtendedEventArgs(string propertyName, object oldValue, object newValue)
    {
        PropertyName = propertyName;
        OldValue = oldValue;
        NewValue = newValue;
    }
}
