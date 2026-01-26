using ObjectsReview;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Objects
{
    class Parking
    {
        private uint pointer;
        private readonly Car[] cars;

        public Parking(int capacity)
        { 
            cars = new Car[capacity];
        }

        public void Add(Car car)
        {
            if (pointer < cars.Length)
            {
                cars[pointer++] = car;
            }
        }

        public Car this[string index]
        {
            get
            {
                for (int i = 0; i < pointer; i++)
                    if (cars[i].Vin == index)
                    {
                        return cars[i];
                    }

                return null;
            }       
        }

        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < pointer)
                    return cars[index];

                return null;
            }           
        }

       

     

    }
}
