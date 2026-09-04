using RewiewEssensial.Extensions;

namespace RewiewEssensial
{
    public abstract class Person : IInfo
    {
        protected string phone;  

        public string Info { get; set; }

        public Person(string name, string phone)
        {
            Name = name;
            this.phone = phone;
        }

        public Person(string name, string phone, DateOnly dateOfBirth)
            :this(name, phone)
        {
            DateOfBirth = dateOfBirth;
        }

        public string Name
        {
            get
            {
                return field ?? "EmptyName";
            }
            set
            {
                if (value?.ToUpper() != "FOOL")
                {
                    field = value;
                }
            }
        }

        public DateOnly DateOfBirth 
        {
            get => field;
            set
            {
                if (value < new DateOnly(1950, 1, 1))
                    throw new InvalidOperationException("Invalid date of birth. Please enter a date after January 1, 1950.");


                field = value;
            }
        }

        public required string IPN { get; init; } 


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date of Birth: {DateOfBirth}");
            Console.WriteLine($"IPN: {IPN}");
        }

        public abstract void SendMessage(string message);

        public string UpdateInfo()
        {
            return $"Person: {Name}, Date of Birth: {DateOfBirth}, IPN: {IPN}";
        }
    }
}
