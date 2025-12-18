namespace VariablesReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 250; // 1 0..255
            long b = 20; // 2
            long c = 3000000000; // 3
            int x = 1000; // 4 

            b = a; // 2 <- 1

            double d = 2.4;

            a = (byte)x;

            var result = (double)(x + 2.45);

            Console.WriteLine(result);

            int res;


            if (a > 100)
            {
                res = -1;
            }
            else
            {
                res = 100;
            }
            bool isEmpty = false;

            res = (a > 100) ? (x < 10) ? 12 : 44  : (isEmpty) ? 56 : 78;


            if (a > 100)
            {
                if (x < 10)
                {
                    res = 12;
                }
                else
                {
                    res = 44;
                }
            }
            else
            {
                if (isEmpty)
                {
                    res = 56;
                }
                else
                {
                    res = 78;
                }
            }

            int var33 = (x) switch
            {
                23 => 1,
                44 => 2,
                56 => 3,
                _ => 0
            };
        }
    }
}
