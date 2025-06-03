namespace APIMain;

using System;
using System.Collections.Generic;
using System.Linq;

public class FlexibleSomeEntityApiClient
{
    private readonly SomeEntityRepository _repository;

    public FlexibleSomeEntityApiClient(SomeEntityRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<SomeEntity> GetEntities(EntityQueryCriteria criteria)
    {
        IEnumerable<SomeEntity> query = _repository.GetMany();

        // Фильтрация по имени (без учета регистра)
        if (!string.IsNullOrEmpty(criteria.Filter))
        {
            query = query.Where(e => e.Name != null &&
                                     e.Name.IndexOf(criteria.Filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // Сортировка
        if (!string.IsNullOrEmpty(criteria.SortBy))
        {
            if (criteria.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
            {
                query = criteria.Descending ? query.OrderByDescending(e => e.Name)
                                            : query.OrderBy(e => e.Name);
            }
            else if (criteria.SortBy.Equals("Id", StringComparison.OrdinalIgnoreCase))
            {
                query = criteria.Descending ? query.OrderByDescending(e => e.Id)
                                            : query.OrderBy(e => e.Id);
            }
        }

        // Постраничный вывод
        if (criteria.Page.HasValue && criteria.PageSize.HasValue)
        {
            int skip = (criteria.Page.Value - 1) * criteria.PageSize.Value;
            query = query.Skip(skip).Take(criteria.PageSize.Value);
        }

        return query;
    }
}
