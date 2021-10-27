using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    class Dog : Animals
    {

        public Dog(string DogSpecies, string DogName, int DogAge, string DogGender, string DogSound, string DogFood, string DogOwner) : base(DogSpecies, DogName, DogAge, DogGender, DogSound, DogFood)
        {
            Owner = DogOwner;
        }
        public string Owner = "empty";

        public Dog() : base()
        {

        }
        public void PrintOwnerName()//metod för djurens egna ewgenskap
        {
            Console.WriteLine(AnimalName + "s Owner is " + Owner);
        }
    }
}
