using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public abstract class DomasticAnimal : Animal
    {
        protected DomasticAnimal(string name) 
            : base(name)
        {
        }

        public string OwnerName { get; set; }

        public byte PleasureLevel { get; set; }

        public virtual void Play()
        {
            PleasureLevel++;
        }
    }
}
