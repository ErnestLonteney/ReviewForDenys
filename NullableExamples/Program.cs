namespace NullableExamples
{
    internal class Program
    {
        public static bool? Answer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            if (answer == "yes")
                return true;
            else if (answer == "no")
                return false;
            else
                return null;

        }

        public static double? Divide(double a, double b)
        {
            if (b == 0)
                return null;

            return a / b;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Input values for division:");
            //Console.WriteLine("Input a");
            //double aDouble = double.Parse(Console.ReadLine());
            //Console.WriteLine("Input b");
            //double bDouble = double.Parse(Console.ReadLine());


            //var result = Divide(aDouble, bDouble);

            //if (result is not null)
            //{
            //    Console.WriteLine("Result: " + result.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //}


            //int a = 10;
            //bool? b = Answer("Do you want to continue?");

            //if (b.HasValue)
            //{
            //    Console.WriteLine("You have answered: " + b.Value);
            //}
            //else
            //{
            //}

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            var person = new Person("John", "Doe");
            Console.WriteLine(person.Email?.Trim().Length);
        }
    }
}
