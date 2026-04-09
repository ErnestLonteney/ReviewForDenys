namespace Generics
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static int Add<T>(T a, T b) where T : struct
        {
            return a.GetHashCode() + b.GetHashCode();
        }  

        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Swap<int>(ref a, ref b); 

            Console.WriteLine($"a={a} b={b}");

            double x = 10.34, y = 20.34;

            Swap<double>(ref x, ref y);

            Console.WriteLine($"x={x} y={y}");

            string s1 = "10", s2 = "20";

            Swap<string>(ref s1, ref s2);

            DateTime d1 = DateTime.Now, d2 = new DateTime(2026, 5, 1, 7, 2, 3);

            Swap<DateTime>(ref d1, ref d2);

            Console.WriteLine($"s1={s1} s2={s2}");

            decimal m1 = 10.34m;
            decimal m2 = 20.34;   
            
            var res =  Add<decimal>(m1, m2);

            Console.WriteLine(res);

            var r = Add<string>("2334", "34345"); 

            Console.WriteLine(res2);

            var greeter = new Greeter<string, DateTime>(
                new DateTime(1986, 1, 1), 
                new DateTime(2004, 1, 3), 
                new DateTime(2026,1, 11),
                new DateTime(2000, 4, 4),
                new DateTime(2009, 4, 5));    

            greeter.Greet("Volodymyr");

            var greeter2 = new Greeter<int, string>("Best worker", "best quality", "winner 2034");

            greeter2.Greet(3435345);

        }
    }
}
