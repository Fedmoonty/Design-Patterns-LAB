namespace Car_App;

using System;
using System.Collections.Generic;

public class Container
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
        Console.WriteLine($"Добавлен экземпляр: {car.GetType().Name}");
        car.PropertyChanged += Car_PropertyChanged;
    }

    private void Car_PropertyChanged(object sender, PropertyChangedExtendedEventArgs e)
    {
        if (sender is Car car)
        {
            Console.WriteLine($"Изменено свойство '{e.PropertyName}' в экземпляре {car.GetType().Name}. " +
                              $"Старое значение: {e.OldValue}, новое значение: {e.NewValue}");
        }
    }
}

