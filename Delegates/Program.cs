

namespace Delegates
{
    internal class Program
    {    

        static void Main(string[] args)
        {
            int[] array = [23, 45, 66, 0, -90, 78, 13, 100];

            var result = array.Filter((number) => number > 0);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            var result2 = array.Filter((number) => number % (2) == 0);

            for (int i = 0; i < result2.Length; i++)
            {
                Console.WriteLine(result2[i]);
            }

        }
    }
}
