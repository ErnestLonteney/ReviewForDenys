using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public class Tiger : WildAnimal
    {
        public Tiger(string name) 
            : base(name)
        {
        }

        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat meat");
        }

        public override void Hunt()
        {
            Console.WriteLine("Run");
            Console.WriteLine("Kill");
        }

        public override void Talk()
        {
            Console.WriteLine("Hrrr");
        }
    }
}
