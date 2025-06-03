namespace APIMain;

using System;
using System.Collections.Generic;
using System.Linq;

public class SomeEntityRepository
{
    private readonly List<SomeEntity> _entities = new List<SomeEntity>();

    public SomeEntity Create(SomeEntity entity)
    {
        entity.Id = _entities.Count > 0 ? _entities.Max(e => e.Id) + 1 : 1;
        _entities.Add(entity);
        return entity;
    }

    public SomeEntity Update(SomeEntity entity)
    {
        var existing = _entities.FirstOrDefault(e => e.Id == entity.Id);

        if (existing == null)
        {
            throw new Exception("Сущность не найдена");
        }

        existing.Name = entity.Name;
        existing.Description = entity.Description;
        existing.Status = entity.Status;
        return existing;
    }

    public SomeEntity GetOne(int id)
    {
        return _entities.FirstOrDefault(e => e.Id == id);
    }

    public List<SomeEntity> GetMany()
    {
        return _entities;
    }

    public IEnumerable<SomeEntity> GetByFilter(Func<SomeEntity, bool> predicate)
    {
        return _entities.Where(predicate);
    }

    public void Delete(int id)
    {
        var entity = GetOne(id);
        if (entity != null)
            _entities.Remove(entity);
    }

    public void DeleteMany(List<int> ids)
    {
        _entities.RemoveAll(e => ids.Contains(e.Id));
    }

    public string Print(int id)
    {
        var entity = GetOne(id);
        return entity == null ? "Сущность не найдена" : $"Print: {entity.Name} - {entity.Description}";
    }

    public IEnumerable<string> PrintMany(List<int> ids)
    {
        return _entities.Where(e => ids.Contains(e.Id))
                        .Select(e => $"Print: {e.Name} - {e.Description}");
    }

    public SomeEntity SetStatus(int id, string status)
    {
        var entity = GetOne(id);

        if (entity == null)
        {
            throw new Exception("Сущность не найдена");
        }

        entity.Status = status;
        return entity;
    }

    public SomeEntity Deactivate(int id)
    {
        return SetStatus(id, "Inactive");
    }

    public SomeEntity Activate(int id)
    {
        return SetStatus(id, "Active");
    }
}

