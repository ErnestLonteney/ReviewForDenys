namespace ExtensionMethods
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            //Console.WriteLine("Input string");
            //string str = Console.ReadLine();

            //string res = str.CleanString();

            //Console.WriteLine(res);

            Console.WriteLine("Input string");
            string line = Console.ReadLine();

            string cleaned = line.RemoveSpecificCharapters();
            string result = cleaned.WordUpper();

            Console.WriteLine(result);
        }
    }
}
