using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public class Car
    {
        public int CurrentSpeed { get; set; }

        public Car() { }

        
        

        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }
        public void Stop() 
        { 
            Console.WriteLine("Car is stopping...");

        }
    }
}
