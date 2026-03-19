using ObjectsReview;
using System.Collections;

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
    }
}
