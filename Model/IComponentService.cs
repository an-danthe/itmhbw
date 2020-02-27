using System;
using System.Collections.Generic;

namespace itmhbw.Model
{
    public interface IComponentService
    {
        IReadOnlyList<Type> Get();
    }
}