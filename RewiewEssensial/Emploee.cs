namespace RewiewEssensial
{
    public class Employee(string name, string phone, DateOnly dateOfBirth , DateOnly[] vacationDays) : Person(name, phone, dateOfBirth), IPrintable
    {
        private Action<Employee> payRise;

        public event Action<Employee> PayRise
        {
            add
            {
                Console.WriteLine("Pay rise event added.");
                payRise += value;
            }
            remove
            {
                payRise -= value;
            }
        }


        public decimal Salary { get; set; }

        public string Title { get; set; } = string.Empty;

        public DateOnly this[int index]
        {
            get => vacationDays[index];
        }

        public DateOnly this[string index]
        {
            get => (index) switch 
                {
                     "First" => vacationDays[0],
                     "Second" => vacationDays[1],
                     _ => DateOnly.Parse(DateTime.Now.ToString())   
                };
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Phone: {phone}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"Message sent via Teams: {message}");
        }


        public string GetPrintableInfo()
        {
            return $"Name: {Name}, Date of Birth: {DateOfBirth}, IPN: {IPN}, Salary: {Salary}, Title: {Title}";
        }


        public void Review()
        {
            if (12 == 12)
            {
                Salary += 1000; 
                payRise?.Invoke(this);
            }
        }
    }
}
