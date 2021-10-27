using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    class Bird : Animals
    {
        public Bird(string BirdSpecies, string BirdName, int BirdAge, string BirdGender, string BirdSound, string BirdFood, int Speed) : base(BirdSpecies, BirdName, BirdAge, BirdGender, BirdSound, BirdFood)
        {
            FlygingSpeed = Speed;
        }
        public int FlygingSpeed = 0;
        public Bird() : base()
        {

        }
        public void PrintFlyingSpeed()
        {
            Console.WriteLine(AnimalName + " can fly " + FlygingSpeed + " km/h");
        }
    }
}

