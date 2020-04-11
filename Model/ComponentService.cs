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
                typeof(BlazorIntro),
                typeof(ComponentPhys),
                typeof(ComponentParameters),
                typeof(ComponentUse),
                typeof(ComponentLifeCycle),
                typeof(BlazorTemplate),
                typeof(ComponentDI),
                typeof(BlazorErrors),
                typeof(BlazorInitialization),
                typeof(Ending)
            };

            return list.AsReadOnly();
        }
    }
}