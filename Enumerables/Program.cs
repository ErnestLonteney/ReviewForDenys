using EssencialReview.Part2;
using System.Collections;

namespace Enumerables
{
    internal class Program
    {
        class EnumerableExample : IEnumerable<string>, IEnumerator<string>
        {
            public EnumerableExample(string[] words)
            {
                this.words = words; 
            }

            private int _index = -1;
            private string[] words { get; set; }
            public string Current => words[_index];
            object IEnumerator.Current => Current;
            public IEnumerator<string> GetEnumerator()
            {
                return this;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this;
            }
            public bool MoveNext()
            {
                while (_index < words.Length)
                {
                    if (words[_index] != null && words[_index].StartsWith("A"))
                    {
                        _index++;
                        return _index < words.Length;
                    }
                    else
                    {
                        _index++;

                    }
                }

                return false;
            }
            public void Reset()
            {
                _index = -1;
            }
            public void Dispose()
            {
            }
            
        }

            static IEnumerable<string> GetNumbers2(string[]? wordsA)
            {
                return new EnumerableExample(wordsA);
            }

        static IEnumerable<string> GetNumbers(string[]? wordsA)
        {
            if (wordsA == null || wordsA.Length == 0)
                yield break;

            foreach (var word in wordsA) 
            {
                if (word.StartsWith("A"))
                {
                    yield return word;
                }
            }
        }

        static void Main(string[] args)
            {
                var car1 = new Car
                {
                    Make = "BMW",
                    Model = "X5",
                    VIN = "123456"
                };

                var car2 = new Car
                {
                    VIN = "232314",
                    Model = "X6",
                    Make = "BMW"
                };

                var parking = new Parking
            {
                car1,
                car2
            };


                foreach (var car in parking)
                {
                    Console.WriteLine($"Car: {car.Make} {car.Model}, VIN: {car.VIN}");
                }
                string[] words = ["Apple", "Banana", "Avocado", "Apricot", "Asparagus", "Orange"];

                foreach (var word in GetNumbers(words))
                {
                    Console.WriteLine(word);
                }
            }
        }
}
