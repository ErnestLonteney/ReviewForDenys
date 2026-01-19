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

            //car2.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    car2.Acelerate(10);
            //}

            //Console.WriteLine(car2.CurrentSpeed);

            SportCar sportCar = new SportCar("Lamborghini", "Diablo", "Red")
            {
                Color = "Red",
                NitroVolume = 100
            };

            //sportCar.Acelerate(50);

            //Console.WriteLine(sportCar.Mark);
            //Console.WriteLine(sportCar.Model);

            Car[] cars = [car1, car2, sportCar];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].Mark);
                Console.WriteLine(cars[i].Model);
                cars[i].Start();

                for (int j = 0; j < 5; j++)
                {
                    cars[i].Acelerate((uint)(j + 10));
                    Console.WriteLine(cars[i].CurrentSpeed);
                }

                Console.WriteLine(new String('-', 50));
            }           
        }
    }
}
