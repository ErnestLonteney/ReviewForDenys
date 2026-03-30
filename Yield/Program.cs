using Yield;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] array = {-10, 20, 30, -20, -40, 50, -90};

        foreach (int i in Numbers.Number(array))
        {
            Console.WriteLine(i);
        }

        IEnumerable result = Words.GenerateWords(null);
        foreach (string i in result)
        {
            Console.WriteLine(i);
        }
        
    }
}
