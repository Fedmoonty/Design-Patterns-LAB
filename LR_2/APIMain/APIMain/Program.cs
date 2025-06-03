namespace APIMain;

using System;

public class Program
{
    public static void Main()
    {
        // Инициализация репозитория и базового API-клиента
        SomeEntityRepository repository = new SomeEntityRepository();
        SomeEntityApiClient apiClient = new SomeEntityApiClient(repository);

        // Создаем несколько сущностей
        apiClient.Create(new SomeEntity { Name = "Entity1", Description = "Description1", Status = "Active" });
        apiClient.Create(new SomeEntity { Name = "Entity2", Description = "Description2", Status = "Inactive" });
        apiClient.Create(new SomeEntity { Name = "Test Entity", Description = "Test Desc", Status = "Active" });

        // Обновляем первую сущность
        var updated = apiClient.Update(new SomeEntity { Id = 1, Name = "Entity1 Updated", Description = "Updated Desc", Status = "Active" });
        Console.WriteLine($"Updated: {updated.Name}");

        // Получаем сущность с Id = 2
        var entity = apiClient.GetOne(2);
        Console.WriteLine($"Got entity: {entity.Name}");

        // Метод "Print"
        Console.WriteLine(apiClient.Print(1));

        // Используем гибкий API-клиент с критериями
        EntityQueryCriteria criteria = new EntityQueryCriteria
        {
            Filter = "Entity",
            SortBy = "Name",
            Descending = false,
            Page = 1,
            PageSize = 2
        };
        FlexibleSomeEntityApiClient flexibleClient = new FlexibleSomeEntityApiClient(repository);
        Console.WriteLine("\nFlexible API Client Results:");
        foreach (var e in flexibleClient.GetEntities(criteria))
        {
            Console.WriteLine($"{e.Id}: {e.Name}");
        }

        // Работа с новым API для изображений
        SomeImageEntityApiClient imageClient = new SomeImageEntityApiClient(apiClient);
        var imageEntity = imageClient.GetImage(1);
        Console.WriteLine($"\nImage Entity: {imageEntity.Name}, ImageUrl: {imageEntity.ImageUrl}");
    }
}