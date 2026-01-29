using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public class Zebra : WildAnimal
    {
        public Zebra(string name) 
            : base(name)
        {
        }
        public override string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eats grass");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking on the savannah");
        }
        public override void Talk()
        {
            Console.WriteLine("Fr-fr-fr");
        }

        public override void Hunt()
        {
            Console.WriteLine("Run away"); 
        }

    }

}
