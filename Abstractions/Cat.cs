using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public class Cat : DomasticAnimal
    {
        public Cat(string name) 
            : base(name)
        {
        }

        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Drink milk");
        }

        public override void Talk()
        {
            Console.WriteLine("Myau-Myau");
        }


        public override void Play()
        {
            PleasureLevel += 5;
        }
    }
}
