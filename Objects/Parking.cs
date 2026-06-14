using ObjectsReview;
using System.Collections;

namespace Objects
{
    class Parking(int capacity) : IEnumerator<Car>, IEnumerable<Car>    
    {
        private uint pointer;
        private readonly Car[] cars = new Car[capacity];

        private int position = -1;

        public void Add(Car car)
        {
            if (pointer < cars.Length)
            {
                cars[pointer++] = car;
            }
        }

        public Car? this[string vinCode]
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Vin == vinCode)
                        return cars[i];
                }

                return null;
            }
        }

       object IEnumerator.Current => cars[position];

        public Car Current => cars[position];

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < pointer - 1)
            {
                position++;
                return true;
            }
            
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return this;
        }
    }
}
