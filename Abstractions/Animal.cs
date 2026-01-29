using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public abstract class Animal : IPrintable
    {
        protected Animal(string name)
        {
            Name = name;    
        }

        public abstract string Name { get; set; }       

        public string Description { get; set; }

        public byte Level { get; set; }

        public abstract void Eat();

        public abstract void Talk();

        public abstract void Walk();


        public string GetMyInfo()
        {
            return $"Hello! My name is {Name} I am {Level} level";
        }

        public void Print()
        {
            Console.WriteLine("Cat has been printed");
        }
    }
}
