using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EssencialReview.Part2
{
    internal class Parking : IEnumerable<Car>, IEnumerator<Car>
    {
        private readonly List<Car> _cars = new List<Car>();

        private int _index = -1;

        public Car Current => _cars[_index];

        object IEnumerator.Current => Current;

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public Car this[string index]
        {
            get 
            {
                foreach (var car in _cars)
                {
                    if (car.VIN == index)
                        return car;
                }

                throw new Exception("Car not found");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _cars.Count;
        }

        public void Reset()
        {
            _index = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
