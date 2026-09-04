namespace EssencialReview.Part2
{
    internal class Program
    {
        static void LongOperation()
        {
            Console.WriteLine("Starting long operation...");
            Thread.Sleep(5000);
            Console.WriteLine("Long operation completed.");
        }   

        static void Drow(char ch, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        static void Shell(object obj)
        {
            char ch = (char)obj!;
            Drow(ch, 20);
        }

        static void Main()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Hello");

            var threadDrow = new Thread(
            (obj) => 
            {
                char ch = (char)obj!;   
                Drow(ch, 20); 
            });

            threadDrow.Start('*');

            Thread thread = new Thread(new ThreadStart(LongOperation));
            thread.IsBackground = false;
            thread.Start();

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Buy");
                Thread.Sleep(100);
            }
        }
    }
}
