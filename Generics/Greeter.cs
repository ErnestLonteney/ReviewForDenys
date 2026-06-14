using System.Collections;

namespace Generics
{
    public class Greeter<T, K> where T : class where K : IConvertible
    {
        private readonly K[] values;

        public Greeter(params K[] array)
        {
            values = array;
        }


        public void Greet(T name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello, {name}!");

            Console.ResetColor();

            foreach (K item in values)
            {
                var rnd = new Random();
                int index = rnd.Next(0, 15);
                Console.ForegroundColor = (ConsoleColor)index;
                Console.WriteLine(item);
            }

        }
    }
}
