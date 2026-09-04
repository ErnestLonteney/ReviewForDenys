
using RewiewEssensial.Extensions;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace RewiewEssensial
{ 
    internal class Program
    {
        static void DisplayName(string name, Action<string> display)
        {
            string clear = name.Replace('*', ' ').Replace('%', ' ').ToUpper();
            display.Invoke(clear);
        }

        static Rectangle GetRectangle(int a)
        {
            if (a == 0)
            {
                return new Rectangle(0, 0)
                {
                    IsEmpty = true
                };
            }   

            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            return new Rectangle(width, height)
            {
                IsEmpty = false
            };


        }

        static void Main(string[] args)
        {

            //  var director = new Director("John Doe", "123-456-7890", new DateOnly(1985, 10, 15), "Sales")
            //  {
            //      IPN = "2323423423"
            //  };

            //  director.Name = "Fool";


            //  Console.WriteLine($"Name: {director.Name}");


            //  director.DateOfBirth = new DateOnly(1990, 5, 15);

            //  Console.WriteLine($"Date of Birth: {director.DateOfBirth}");

            var employee = new Employee("Jane Smith", "987-654-3210", new DateOnly(1995, 8, 20), [new DateOnly(2023, 8, 20), new DateOnly(2023, 8, 21)])
            {
                IPN = "9876543210",
                Salary = 50000.00m,
                Title = "Software Engineer"
            };

            employee.PayRise += (e) =>
            {
                Console.WriteLine($"Send letter to employee to {e.Name}");
            };

            employee.Review();  


            //   Person person1 = employee;

            //   Employee employee1 = (Employee)person1;


            //  Person[] people = [director, employee];

            //  foreach (var p in people)
            //  {
            //      p.DisplayInfo();
            //  }


            //  Console.WriteLine($"Vacation Day 1: {employee1[0]}");
            //  Console.WriteLine($"Vacation Day 2: {employee1[1]}");

            //  Console.WriteLine($"Vacation Day 1: {employee1["First"]}");
            //  Console.WriteLine($"Vacation Day 2: {employee1["Second"]}");


            //  Rectangle rectangle = new Rectangle(5.0, 10.0)
            //  {
            //      IsEmpty = false
            //  };

            //  IPrintable[] printableObjects = [director, employee];

            //  foreach (var printable in printableObjects)
            //  {
            //      Console.WriteLine(printable.GetPrintableInfo());
            //  }

            //  Rectangle rect2 = rectangle;

            //  rect2.Width = 7.0;

            //  Console.WriteLine(rectangle.Width);

            //  rect2.Print();


            //  var res = GetRectangle(0);

            //  if (!res.IsEmpty)
            //  {

            //  }

            //  int? a = 10;

            //  if (a.HasValue)
            //      Console.WriteLine(a.Value);

            //  //  var res3 = employee1 ?? new Employee(); 

            //  Calculator.LicenseKey = "NewLicenseKey";

            //  Calculator.Add(5, 3);
            //  Calculator.Subtract(10, 4);

            // // Calculator calculator = new Calculator("Hanry");


            ////  Calculator calculator1 = new Calculator("Jane");
            Calculator.Add(5, 3);
            Calculator.Subtract(10, 4);

            //  Calculator.GetInfo();   


            //  DoubleExtensions.Add(5.5, 3.2);
            //  DoubleExtensions.Subtract(10.5, 4.3);

            //  double aDouble = 5.5;

            //  var result = aDouble.Add(3.2);

            //  var result2 = 3.5.Subtract(1.2);

            //  // Up-Cast 
            //  IInfo inf = rect2;

            //  object inf2 = rect2;

            //  ValueType inf3 = rect2;


            //  Rectangle rectangle11 = (Rectangle)inf2;

            //  if (employee1.EmploymentType == EmployeeType.FOP)
            //  {
            //      Console.WriteLine("Employee is a FOP.");
            //  }

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine() ?? string.Empty;
            
            DisplayName(name, (str) =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine(str);
            });
            DisplayName(name, (str) => Debug.WriteLine(str));
        }
    }
}
