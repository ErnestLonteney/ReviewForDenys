using System.Numerics;
using System.Text;

namespace ArraysReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;       

            short count; // 2 байти
            count = 10; // 00000000 00001010

            Console.WriteLine(count);

            // 0                       //  1                     // 2
            DateTime[] birthdays = [new DateTime(1990, 1, 10), new DateTime(1987, 2, 2), new DateTime(1978, 3, 4)];
            DateTime[] hireDate = [];

            for (int i = 0; i < birthdays.Length; i++)
            {
                Console.WriteLine($"Bithday ={birthdays[i]}");
            }

            string[,] checks = new string[8, 8];

            checks[4, 3] = "Ферзь";    
            for (int i = 0; i < 8; i++)
                checks[1, i] = "Пішак";
            
            // Вisplay board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(checks[i, j]);
                }
            }
            
            string[,,] checks3 = new string[8, 8, 8];
            string[,,,] checks4 = new string[5, 8, 8, 8];

            checks4[3, 2, 4, 1] = "45";

        }
    }
}
