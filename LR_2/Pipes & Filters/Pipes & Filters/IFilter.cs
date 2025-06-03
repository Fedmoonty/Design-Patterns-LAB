using System;
using System.Collections.Generic;
using System.Text;

namespace LR2_0;

public interface IFilter<T>
{
    T Process(T input);
}
