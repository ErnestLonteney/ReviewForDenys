namespace ExceptionsReview
{
    internal class Program
    {
        static double Divide(double a, double b)
        {
            if (a == 100)
            {
                var innerException = new HundredException() { Staus = 117 };
                throw new ArgumentException("a is not valid value", innerException);
            }

            if (b == 100)
            {
                throw new HundredException() { Staus = 99 };
            }

            if (a == 0 && b == 0)
                throw new ArgumentException("Both a and b cannot be zero");

            if (b == 0)
                throw new DivideByZeroException("b cannot be zero");
           
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input values for division:");
            Console.WriteLine("Input a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            double b = double.Parse(Console.ReadLine());

            double result = -1;

            try
            {
                result = Divide(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (HundredException ex) when (ex.Staus == 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (HundredException ex) when (ex.Staus == 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (HundredException ex)
            {
                Exception current = ex.InnerException;
                while (current != null)
                {
                    Console.WriteLine(current.Message);
                    current = current.InnerException;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine(result);
        }
    }
}
