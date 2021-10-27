using System;                   //Erik Norell sut21
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    class Pug : Dog
    {
        public Pug(string DogSpecies, string DogName, int DogAge, string DogGender, string DogSound, string DogFood, string DogOwner, string Type) : base(DogSpecies, DogName, DogAge, DogGender, DogSound, DogFood, DogOwner)
        {
            DogType = Type;
        }
        public Pug() : base()
        {

        }
        public string DogType = "empty";
        public void PrintDogType()
        {
            Console.WriteLine(AnimalName + " is a " + DogType);
        }
    }
}
