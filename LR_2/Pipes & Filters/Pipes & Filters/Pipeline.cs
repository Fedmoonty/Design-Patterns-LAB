using System.Collections.Generic;

namespace LR2_0;

public class Pipeline<T>
{
    private readonly List<IFilter<T>> _filters = new List<IFilter<T>>();

    public Pipeline<T> AddFilter(IFilter<T> filter)
    {
        _filters.Add(filter);
        return this;
    }

    public T Execute(T input)
    {
        T output = input;
        foreach (var filter in _filters)
        {
            output = filter.Process(output);
        }
        return output;
    }
}

