using System;                       //Erik Norell sut21
using System.Collections.Generic;
using System.Text;

namespace labb2_arv

{
    class Animals
    {   //skapar variablar för obligatoriska egenskaper för alla djur
        public string AnimalSpecies = "empty";
        public string AnimalName = "empty";
        public int AnimalAge = 0;
        public string AnimalGender = "empty";
        public string AnimalSound = "empty";
        public string AnimalFood = "empty";

        public Animals()
        {

        }

        public Animals(string Species, string name, int age, string gender, string sound, string food)//Construktor för att skapa nytt djur
        {
            AnimalSpecies = Species;
            AnimalName = name;
            AnimalAge = age;
            AnimalGender = gender;
            AnimalSound = sound;
            AnimalFood = food;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Species: " + AnimalSpecies);
            Console.WriteLine("Name: " + AnimalName);
            Console.WriteLine("Age: " + AnimalAge);
            Console.WriteLine("Gender: " + AnimalGender);

        }//medtod för att skriva ut info om djur
        public void MakeSound()
        {
            Console.WriteLine(AnimalSpecies + " says " + AnimalSound);
        }//metod för att skriva ut ljud för djur
        public void Food()
        {
            Console.WriteLine(AnimalSpecies + " eats " + AnimalFood);
        }//metod för att skriva ut mat för djur
    }
}