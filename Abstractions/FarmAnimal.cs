using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public abstract class FarmAnimal : Animal
    {
        protected FarmAnimal(string name) 
            : base(name)
        {
        }
        abstract public void Graze();

    }
}
