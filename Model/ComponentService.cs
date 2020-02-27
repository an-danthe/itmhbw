using System;
using System.Collections.Generic;
using itmhbw.Components;

namespace itmhbw.Model
{
    public class ComponentService : IComponentService
    {
        public IReadOnlyList<Type> Get()
        {
            var list = new List<Type>
            {
                typeof(Greeting),
                typeof(Ending)
            };

            return list.AsReadOnly();
        }
    }
}