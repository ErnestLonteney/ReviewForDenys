using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public abstract class WildAnimal : Animal
    {
        protected WildAnimal(string name) 
            : base(name)
        {
        }

        public abstract void Hunt();
    }
}
