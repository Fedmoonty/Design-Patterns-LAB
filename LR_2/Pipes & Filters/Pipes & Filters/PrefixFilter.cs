using System;
using System.Collections.Generic;
using System.Text;

namespace LR2_0;

public class PrefixFilter : IFilter<string>
{
    private readonly string _prefix;

    public PrefixFilter(string prefix)
    {
        _prefix = prefix;
    }

    public string Process(string input)
    {
        return $"{_prefix}{input}";
    }
}

