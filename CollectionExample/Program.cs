namespace CollectionExample
{
    internal class Program
    {
        static void Display(Parking parking)
        {
            foreach (var car in parking)
            {
                Console.WriteLine($"Mark: {car.Mark}, Make: {car.Make}, Issue Date: {car.IssueDate}, VIN: {car.VIN}, Color: {car.Color}");
            }

            Console.WriteLine(new string('-', 80));
        }

        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Mark = "Toyota",
                Make = "Camry",
                IssueDate = new DateOnly(2020, 5, 15),
                VIN = "1HGCM82633A123456",
                Color = "Blue"
            };

            Car car2 = new Car
            {
                Mark = "Honda",
                Make = "Civic",
                IssueDate = new DateOnly(2019, 8, 20),
                VIN = "2HGCM82633A654321",
                Color = "Red"
            };  

            Car car3 = new Car
            {
                Mark = "Ford",
                Make = "Mustang",
                IssueDate = new DateOnly(2021, 3, 10),
                VIN = "3HGCM82633A987654",
                Color = "Black"
            };

            Car car4 = new Car
            {
                Mark = "Chevrolet",
                Make = "Malibu",
                IssueDate = new DateOnly(2018, 11, 5),
                VIN = "4HGCM82633A456789",
                Color = "White"
            };

            Car car5 = new Car
            {
                Mark = "Nissan",
                Make = "Altima",
                IssueDate = new DateOnly(2022, 1, 25),
                VIN = "5HGCM82633A321987",
                Color = "Silver"
            };

            Car car6 = new Car
            {
                Mark = "BMW",
                Make = "3 Series",
                IssueDate = new DateOnly(2020, 7, 30),
                VIN = "6HGCM82633A654987",
                Color = "Gray"
            };

            var parking = new Parking { car1, car2, car3, car4, car5 };
            parking.Add(car6);

            Display(parking);

            parking.Remove(car3);

            Display(parking);

            bool containsCar2 = parking.Contains(car2);
            Console.WriteLine($"Contains car2: {containsCar2}");


            Car[] carArray = new Car[20];
            parking.CopyTo(carArray, 3);

            foreach (Car car in carArray)
            {
                if (car == null)
                    continue;

                Console.WriteLine(car.Mark);
                Console.WriteLine(car.Make);
            }

            Car car7 = parking[4];

            Console.WriteLine(car7.VIN);


            int index = parking.IndexOf(car4);
          //  parking.Insert(index, new Car { IssueDate = new DateOnly(2023, 1, 1) });

            parking.RemoveAt(index);

            Display(parking);

            Console.WriteLine($"Index of car5: {index}");

            parking.Clear();

            Display(parking);

        }

    }
}
