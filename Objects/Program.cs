using Objects;

namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Audi", "TT")
            {
                Color = "Blue",
            };

            Console.WriteLine(car1.Color);
            Console.WriteLine($"Color = {car1.Color}");
            Console.WriteLine(car1.Mark);

            var car2 = new Car("Renault", "Megan", "White")
            {
                Color = "White"
            };

            car2.Start();
            for (int i = 0; i < 10; i++)
            {
                car2.Acelerate(10);
            }

            Console.WriteLine(car2.CurrentSpeed);
           
            SportCar sportCar = new SportCar("Lamborghini", "Diablo", "Red")
            {
                Color = "Red"
            };

            sportCar.AccelerateWithNitro(50);

            Console.WriteLine(sportCar.Mark);
            Console.WriteLine(sportCar.Model);

        }
    }
}
