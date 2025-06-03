namespace APIMain;

using System.Collections.Generic;
using System.Linq;

public class SomeImageEntityApiClient
{
    private readonly SomeEntityApiClient _baseClient;

    public SomeImageEntityApiClient(SomeEntityApiClient baseClient)
    {
        _baseClient = baseClient;
    }

    public SomeImageEntity GetImage(int id)
    {
        var entity = _baseClient.GetOne(id);
        if (entity == null)
        {
            throw new NullReferenceException(nameof(entity));
        }
        return new SomeImageEntity
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            Status = entity.Status,
            ImageUrl = "https://default.image.url/sample.jpg",
        };
    }

    public SomeImageEntity SetImage(int id, string imageUrl)
    {
        var entity = _baseClient.GetOne(id);
        if (entity == null)
        {
            throw new NullReferenceException(nameof(entity));
        }
        
        return new SomeImageEntity
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            Status = entity.Status,
            ImageUrl = imageUrl
        };
    }

    public IEnumerable<SomeImageEntity> GetEntitiesByFilter(string name)
    {
        var entities = _baseClient.GetByFilter(name);
        return entities.Select(e => new SomeImageEntity
        {
            Id = e.Id,
            Name = e.Name,
            Description = e.Description,
            Status = e.Status,
            ImageUrl = "https://default.image.url/filter.jpg"
        });
    }
}

