using Objects;
using System.Runtime.CompilerServices;

namespace ObjectsReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Lock locker = new Lock();

            var car1 = new SportCar("Audi", "TT", Color.Blue)
            {
                NitroVolume = 100,
                Vin = "21338uje93ed32ws5"
            };
            car1.Launch += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
            };
            car1.Stopped += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
            };
            Console.WriteLine(car1);

            var car2 = new Sedan("Renault", "Megan", Color.White)
            {
                Vin = "24558uje93edjjyrd",
                Number = "ABC123"
            };
            car2.Launch += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
            };
            car2.Stopped += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
            };
            Console.WriteLine(car2);

            var car3 = new Crossower("Volkswagen", "Arteon", Color.Black) 
            {
                Vin = "123jhuje93edjina4",
                Number = "XYZ789"
            };
            car3.Launch += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
            };
            car3.Stopped += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
            };
            Console.WriteLine(car3);

            var car4 = new SportCar("Lamborghini", "Diablo", Color.Yellow)
            {
                NitroVolume = 100,
                Vin = "21458u2343edjina4"
            };
            car4.Launch += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
            };
            car4.Stopped += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
            };
            Console.WriteLine(car4);

            var car5 = new Sedan("Mercedes", "Sprinter", Color.Black)
            {
                Vin = "21458u2343edjina4",
                Number = "JKL012"
            };
            car5.Launch += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
            };
            car5.Stopped += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
            };
            Console.WriteLine(car5);

            bool res = car4.Equals(car5);
            Console.WriteLine($"Equals :{res}");

            bool res2 = Object.Equals(car4, car5);
            Console.WriteLine($"Object.Equals :{res2}");

            bool res3 = Object.ReferenceEquals(car4, car1);
            Console.WriteLine($"Object.ReferenceEquals :{res3}");

            Car[] cars = [car1, car2, car3, car4, car5];

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
                Console.WriteLine($"{car.Mark}, {car.Model}");
                car.Start();

                if (car is SportCar sportCar)
                {
                    car.TurnOnRadio();
                }

                try
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int number = random.Next(10, 15);
                        car.Acelerate((uint)(j + number));
                        Console.WriteLine(car.CurrentSpeed);
                    }
                }
                catch (DeadEngineException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                finally
                {
                    Console.ResetColor();
                }

                car.Stop();

                if (car is SportCar sportCar2)
                {
                    car.TurnOffRadios();
                }

                Console.WriteLine(new String('-', 50));          
            }

            Console.WriteLine(new String('*', 50)); 
            Console.WriteLine("Run asynchronously");

            for (int j = 0; j < cars.Length; j++)
            {
                var currentCar = cars[j];
                new Thread(new ThreadStart(() =>
                {
                    lock (locker)
                    {
                        Console.WriteLine($"{currentCar.Mark} {currentCar.Model}");
                        currentCar.Start();
                    }
                    for (int k = 0; k < random.Next(10, 100); k++)
                    {
                        try
                        {
                            currentCar.Acelerate((uint)k + 2);
                            lock (locker)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{currentCar.Mark} {currentCar.Model} - {currentCar.CurrentSpeed} km/h");
                                Console.ResetColor();
                            }
                        }
                        catch (DeadEngineException ex)
                        {
                            lock (locker)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            lock (locker)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    }
                })).Start();
            }
        }
    }
}
