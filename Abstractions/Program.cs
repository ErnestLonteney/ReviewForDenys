namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Cat("Murzik");
            Animal myTiger = new Tiger("Leo");
            Dog bobik = new Dog("Bobic");
            Cow cow = new Cow("Manka");
            Hyena hyena = new Hyena("Savage");
            Zebra zebra = new Zebra("Marti");


            Animal[] animals = [myAnimal, myTiger, bobik, cow, hyena, zebra];
           

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].GetMyInfo());
                animals[i].Talk();
                animals[i].Eat();
                animals[i].Walk();


                if (animals[i] is DomasticAnimal domestic)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        domestic.Play();
                    }

                    Console.WriteLine(domestic.PleasureLevel);
                }
                else if (animals[i] is WildAnimal wild)
                {
                    wild.Hunt();
                }
                
                        
                    Console.WriteLine();
            }


            var tom = new Emploee();

            Print((Cat)myAnimal);
            Print(tom);
        }

        private void TalkAndEat(Animal animal)
        {
            animal.Talk();
            animal.Eat();
        }

        private static void Print(IPrintable someone)
        {
            Console.WriteLine(someone.Name);
            someone.Print();    
        }
    }
}
