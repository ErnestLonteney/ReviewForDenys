using ObjectsReview;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Parking : IEnumerator, IEnumerable
    {
        private Car[] cars;

        private int position = -1;

        public Parking(Car[] cars)
        {
            this.cars = cars;
        }

        public Car this[int number]
        {
            get
            {
                for(int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Number == number)
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
            position++;
            return position < cars.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
