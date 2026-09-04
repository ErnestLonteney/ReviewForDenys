using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CollectionExample
{
    internal class Parking : IList<Car> 
    {
        private int _count = -1;
        private Car?[] _cars = new Car?[10];

        public int Count => _count + 1;

        public bool IsReadOnly => false;

        Car IList<Car>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car this[int index]
        {
            get 
            { 
                if (index < 0 || index >= _cars.Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return _cars[index]; 
            }     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cars.GetEnumerator();
        }

        public IEnumerator<Car> GetEnumerator()
        {
            for (int i = 0; i < _cars.Length; i++)
            {
                if (_cars[i] != null)
                    yield return _cars[i];
            }
        }


        private void ResizeArray()
        {
            Car[] newArray = new Car[_cars.Length * 2];
            for (int i = 0; i < _cars.Length; i++)
            {
                newArray[i] = _cars[i];
            }

            _cars = newArray;
        }

        public void Add(Car item)
        {
            if (_count == _cars.Length / 2)
            {
                ResizeArray();
            }

            _cars[++_count] = item;
        }

        public void Clear()
        {
            _cars = new Car[10];
            _count = -1;    
        }

        public bool Contains(Car item)
        {
            foreach (Car car in _cars)
            {
                if (car != null && car == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(Car[] array, int arrayIndex)
        {
            for (int i = 0; i <= _count; i++)
            {
                if (_cars[i] != null)
                    array[arrayIndex++] = _cars[i];
            }
        }

        public bool Remove(Car item)
        {
            for (int i = 0; i <= _count; i++)
            {
                if (_cars[i] != null && _cars[i] == item)
                {
                    _cars[i] = null;
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(Car item)
        {
            for (int i = 0; i <= _count; i++)
            {
                if (_cars[i] != null && _cars[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, Car item)
        {
           
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _count)
                throw new ArgumentOutOfRangeException(nameof(index));

            for (int i = index; i < _count; i++)
            {
                _cars[i] = _cars[i + 1];
            }

            _cars[_count] = null;
            _count--;
        }
    }
}
