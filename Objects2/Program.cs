using Objects;

namespace Objects2
{
    internal class Program
    {
        static void Main()
        {
            var denys = new Person
            {
                FirstName = "Denys",
                LastName = "Shevchenko",
                BirthDate = new DateTime(1990, 5, 23)
            };

            var denys2 = new Person
            {
                FirstName = "Denys",
                LastName = "Shevchenko",
            };

            var denys3 = new Person
            {
                FirstName = "Denys",
            };

            Person[] denys4 = [new("Tom", "Hanigan"), new("Annas", "Kaslou")];


            Console.WriteLine(denys.FirstName);
        }
    }
}
