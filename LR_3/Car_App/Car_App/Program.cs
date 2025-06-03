namespace Car_App;

using System;

public class Program
{
    public static void Main()
    {
        // Создание контейнера для автомобилей.
        Container container = new Container();

        // Создание экземпляров, производных от Car.
        Sedan sedan = new Sedan("Toyota", 120);
        Truck truck = new Truck("Volvo", 5000);

        // Добавление автомобилей в контейнер.
        container.AddCar(sedan);
        container.AddCar(truck);

        // Изменение свойств для вызова уведомлений.
        sedan.Speed = 130;
        sedan.Brand = "Honda";
        truck.LoadCapacity = 5500;
        truck.Brand = "Scania";

        Console.ReadLine();
    }
}

