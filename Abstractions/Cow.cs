using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public class Cow : FarmAnimal
    {
        public Cow(string name) 
            : base(name)
        {
        }

        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eats grass");
        }

        public override void Talk()
        {
            Console.WriteLine("Moooou");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking around the farm");
        }

        public override void Graze()
        {
           Console.WriteLine("Grazing in the field");
        }

    }
}
