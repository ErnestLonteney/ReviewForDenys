namespace ExtensionMethods
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();

           string res =  str.CleanString();

            Console.WriteLine(res);
        }
    }
}
