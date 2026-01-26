using Objects;
using System.Runtime.InteropServices;

namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Audi", "TT")
            {
                Color = "Blue",
                Vin = "2324234"
            };

            Console.WriteLine(car1.Color);
            Console.WriteLine($"Color = {car1.Color}");
            Console.WriteLine(car1.Mark);

            var car2 = new Car("Renault", "Megan", "White")
            {
                Color = "White",
                Vin = "2324234543244"
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
                NitroVolume = 100,
                Vin = "232423454354"
            };

            //sportCar.Acelerate(50);

            //Console.WriteLine(sportCar.Mark);
            //Console.WriteLine(sportCar.Model);

            Car[] cars = [car1, car2, sportCar];

            Parking parking = new Parking(10);

            for (int i = 0; i < cars.Length; i++)
                parking.Add(cars[i]);

            Car car = parking["2324234543244"];


            parking["2324234543244"] = new Car("", "") { Color = "", Vin = "" };


            Console.WriteLine(car.Mark);
            Console.WriteLine(car.Model);

            Console.WriteLine(new String('*', 50));

            for (int i = 0; i < cars.Length; i++)
            {
                var carInParking = parking[i];

                Console.WriteLine(carInParking.Mark);
                Console.WriteLine(carInParking.Model);
            }

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i].Mark);
            //    Console.WriteLine(cars[i].Model);
            //    cars[i].Start();

            //    for (int j = 0; j < 5; j++)
            //    {
            //        cars[i].Acelerate((uint)(j + 10));
            //        Console.WriteLine(cars[i].CurrentSpeed);
            //    }

            //    Console.WriteLine(new String('-', 50));

            // }           
        }
    }
}
