using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    internal class Dog : DomasticAnimal
    {
        private readonly static string[] acceptedNames = ["Bobic", "Jack", "Duk"];

        public Dog(string name) 
            : base(name)
        {
        }

        public override string Name
        {
            get { return field; }
            set
            {
                if (acceptedNames.Contains(value))
                {
                    field = value;
                }
                else
                {
                    field = acceptedNames[0];
                }
            }
        }

        public override void Eat()
        {
            Console.WriteLine("Eat nutrition for dogs");
        }

        public override void Talk()
        {
            Console.WriteLine("Woof-woof");
        }
    }
}
