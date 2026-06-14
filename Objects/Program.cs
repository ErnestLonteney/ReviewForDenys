using Objects;

namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            var car1 = new SportCar("Audi", "TT", Color.Blue)
            {
                NitroVolume = 100,
                Vin = "21338uje93ed32ws5"
            };

            var car2 = new Sedan("Renault", "Megan", Color.White)
            {
                Vin = "24558uje93edjjyrd",
                Number = "ABC123"
            };

            var car3 = new Crossower("Volkswagen", "Arteon", Color.Black) 
            {
                Vin = "123jhuje93edjina4",
                Number = "XYZ789"
            };

            var car4 = new SportCar("Lamborghini", "Diablo", Color.Yellow)
            {
                NitroVolume = 100,
                Vin = "21458u2343edjina4"
            };

            Car[] cars = [car1, car2, car3, car4];

            var parking = new Parking(25);

            for (int i = 0; i < cars.Length; i++)
                parking.Add(cars[i]);

            foreach (Car car in parking)
            {
                car.PrintInfo();
            }


            IInformable? carForInfo = parking["21458u2343edjina4"];

            Console.WriteLine(carForInfo?.Name);
            Console.WriteLine(carForInfo?.Number);
            carForInfo?.PrintInfo();

            var parking2 = new Parking(10)
            {
                new Sedan("Toyota", "Camry", Color.Black)
                {
                    Vin = "10ijd42343edjina4"
                }
            };

            Console.WriteLine(new String('*', 50));

            foreach (Car car in parking)
            {
                Console.WriteLine(car.Mark);
                Console.WriteLine(car.Model);
                car.Start();

                if (car is SportCar sportCar)
                {
                    car.TurnOnRadio();
                }

                for (int j = 0; j < 5; j++)
                {
                    car.Acelerate((uint)(j + 10));
                    Console.WriteLine(car.CurrentSpeed);
                }

                car.Stop();

                if (car is SportCar sportCar2)
                {
                    car.TurnOffRadios();
                }

                Console.WriteLine(new String('-', 50));
            }
        }
    }
}
