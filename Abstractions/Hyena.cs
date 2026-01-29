using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Abstractions
{
    public class Hyena : WildAnimal
    {
        public Hyena(string name)
            : base(name)
        {
        }

        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eats a hare");
        }

        public override void Hunt()
        {
            Console.WriteLine("Ambush");
            Console.WriteLine("Attack");
        }

        public override void Walk()
        {
            Console.WriteLine("walking through the savannah"); 
        }

        public override void Talk()
        {
            Console.WriteLine("Growl");
        }
    }

   
}
