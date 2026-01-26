using IndexatorsReview;

namespace StructsReview
{  
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyString string11 = new(['H', 'e', 'l', 'l', 'o']);
            MyString string22 = new(['B', 'u', 'y']);

            string11.ConsoleDisplay();
            string22.ConsoleDisplay();

            Console.WriteLine(string11[3]);
         

            string11.ConsoleDisplay();

            MyString result = string11.Concat(['W', 'o', 'r', 'l', 'd']);

            result.ConsoleDisplay();    
        }
    }
}
