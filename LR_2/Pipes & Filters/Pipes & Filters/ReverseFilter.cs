using System;
using System.Collections.Generic;
using System.Text;

namespace LR2_0;

public class ReverseFilter : IFilter<string>
{
    public string Process(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}

