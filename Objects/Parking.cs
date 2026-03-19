using ObjectsReview;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Objects
{
    class Parking : IEnumerator, IEnumerable
    {
        private uint pointer;
        private readonly Car[] cars;

        private int position = -1;

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

        public Car this[string vinCode]
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].VinCode == vinCode)
                        return cars[i];
                }
                return null;
            }
        }

        public object Current => cars[position];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < cars.Length)
            {
                position++;
                return true;
            }
            
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
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
    }
}
