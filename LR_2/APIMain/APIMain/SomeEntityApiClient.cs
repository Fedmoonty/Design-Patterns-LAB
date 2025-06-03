namespace APIMain;

using System;
using System.Collections.Generic;

public class SomeEntityApiClient
{
    private readonly SomeEntityRepository _repository;

    public SomeEntityApiClient(SomeEntityRepository repository)
    {
        _repository = repository;
    }

    public SomeEntity Create(SomeEntity entity) => _repository.Create(entity);

    public SomeEntity Update(SomeEntity entity) => _repository.Update(entity);

    public SomeEntity GetOne(int id) => _repository.GetOne(id);

    public List<SomeEntity> GetMany() => _repository.GetMany();

    public IEnumerable<SomeEntity> GetByFilter(string name)
    {
        return _repository.GetByFilter(e =>
            e.Name != null && e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);
    }

    public void Delete(int id) => _repository.Delete(id);

    public void DeleteMany(List<int> ids) => _repository.DeleteMany(ids);

    public string Print(int id) => _repository.Print(id);

    public IEnumerable<string> PrintMany(List<int> ids) => _repository.PrintMany(ids);

    public SomeEntity SetStatus(int id, string status) => _repository.SetStatus(id, status);

    public SomeEntity Deactivate(int id) => _repository.Deactivate(id);

    public SomeEntity Activate(int id) => _repository.Activate(id);
}