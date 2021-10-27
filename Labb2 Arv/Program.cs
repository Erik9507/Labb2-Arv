using System;

namespace labb2_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mybool = true;
            while (mybool)
            {   //menyval för vad användaren vill göra
                Console.WriteLine("Choose an alternative");
                Console.WriteLine("[1] Print information about all the animals.");
                Console.WriteLine("[2] Add information about a new animal.");
                int input1 = Convert.ToInt32(Console.ReadLine());
                if (input1 == 1)
                {
                    Console.Clear();
                    PrintAllAnimals();
                    Console.WriteLine("Press enter to go to main menu.");
                    Console.ReadKey();
                    Console.Clear();
                    mybool = true;
                }
                else if (input1 == 2)
                {
                    AddAnimal();
                    Console.WriteLine("Press enter to go to main menu.");
                    Console.ReadKey();
                    Console.Clear();
                    mybool = true;
                }
            }
        }
        public static void PrintAllAnimals()//metod för att skriva ut information om alla djurklasser
        {
            Dog dog1 = new Dog("Dog", "Doggy", 4, "Male", "Woof", "Dogfood", "Erik");
            dog1.PrintInfo();
            dog1.MakeSound();
            dog1.Food();
            dog1.PrintOwnerName();

            Console.WriteLine();
            Console.WriteLine();

            Cat cat1 = new Cat("Cat", "Findus", 5, "Female", "Meow", "Catfood", "Socks");
            cat1.PrintInfo();
            cat1.MakeSound();
            cat1.Food();
            cat1.PrintFavouritToy();

            Console.WriteLine();
            Console.WriteLine();

            Bird bird1 = new Bird("Bird", "Birdy", 4, "Male", "Tweet", "Worms", 10);
            bird1.PrintInfo();
            bird1.MakeSound();
            bird1.Food();
            bird1.PrintFlyingSpeed();

            Console.WriteLine();
            Console.WriteLine();

            Pug pug1 = new Pug("Dog", "Fido", 2, "Male", "Woof", "Dogfood", "Erik", "Pug");
            pug1.PrintInfo();
            pug1.MakeSound();
            pug1.Food();
            pug1.PrintDogType();

        }//metod för att skriva ut info om alla djur
        public static void AddAnimal()//metod för att skapa ett nytt djur
        {
            Animals newAnimal = new Animals();
            Console.Write("Type in the spieces: ");
            string newSpecies = Console.ReadLine();
            Console.Write("Type in the name of the animal: ");
            string newName = Console.ReadLine();
            Console.Write("Type in the age of the animal: ");
            int newAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type in the gender of the animal: ");
            string newGender = Console.ReadLine();
            Console.Write("Type in the sound that the animals makes: ");
            string newSound = Console.ReadLine();
            Console.Write("Type in the food that the animal eats: ");
            string newFood = Console.ReadLine();

            newAnimal.AnimalSpecies = newSpecies;
            newAnimal.AnimalName = newName;
            newAnimal.AnimalAge = newAge;
            newAnimal.AnimalGender = newGender;
            newAnimal.AnimalSound = newSound;
            newAnimal.AnimalFood = newFood;

            Console.WriteLine();

            newAnimal.PrintInfo();
            newAnimal.MakeSound();
            newAnimal.Food();

        }
    }
}
