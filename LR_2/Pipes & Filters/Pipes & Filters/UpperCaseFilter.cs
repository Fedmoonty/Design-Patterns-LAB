using System;
using System.Collections.Generic;
using System.Text;

namespace LR2_0;

public class UpperCaseFilter : IFilter<string>
{
    public string Process(string input)
    {
        return input.ToUpper();
    }
}