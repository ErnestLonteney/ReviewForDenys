using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Abstractions
{
    internal class Emploee : IPrintable
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Print of emploee...");
        }
    }
}
