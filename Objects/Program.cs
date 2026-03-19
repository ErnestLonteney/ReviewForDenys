using Objects;

namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var car1 = new Car("Audi", "TT", "WDV1234561A234323", 1)
            {
                Color = "Blue",
            };

            var car2 = new Car("Renault", "Megan", "WHE1717230N128585", 2)
            {
                Color = "White"
            };

            var car3 = new Car("Volkswagen", "Arteon", "JSN1092837A756462", 3)
            {
                Color = "Yellow"
            };

            //car2.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    car2.Acelerate(10);
            //}

            //Console.WriteLine(car2.CurrentSpeed);

            SportCar sportCar = new SportCar("Lamborghini", "Diablo", "IFN1478730N098765", 4)
            {
                Color = "Red",
                NitroVolume = 100
            };

            //sportCar.Acelerate(50);

            //Console.WriteLine(sportCar.Mark);
            //Console.WriteLine(sportCar.Model);

            Car[] cars = [car1, car2, car3, sportCar];

            Parking parking = new Parking(cars);

            foreach (Car car in parking)
            {
                car.PrintInfo();
            }

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

                Console.WriteLine(new string('-', 50));
            }           
        }
    }
}
