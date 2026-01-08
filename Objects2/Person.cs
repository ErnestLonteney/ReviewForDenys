namespace Objects
{
    public class Person
    {
        public Person()
        {
            
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;    
        }

        // private string lastName;
        public string LastName { get; set; }

        // private string firstName;
        public string FirstName { get; set; }

        // private DateTime birthDate;  
        public DateTime BirthDate { get; set; }
        
        public void GoWork()
        {
            Console.WriteLine($"{FirstName} {LastName} is going to work.");
        }
    }
}
