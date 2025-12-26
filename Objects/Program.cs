namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
           
            car1.Color = "Red";

            //car1.mark = "Renault";
            //car1.model = "Megan";


            Console.WriteLine($"Color = {car1.Color}");

            Console.WriteLine(car1.Mark);


            var car2 = new Car();

            //car2.SetColor("Black");
            ////car2.mark = "Honda";
            ////car2.model = "CX34";

            //Console.WriteLine($"Color = {car2.GetColor()}");

            car2.Start();
            for (int i = 0; i < 10; i++)
            {
                car2.Acelerate(10);
            }

            Console.WriteLine(car2.CurrentSpeed);
        }
    }
}
