using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    class Cat : Animals
    {
        public Cat(string CatSpecies, string CatName, int CatAge, string CatGender, string CatSound, string CatFood, string CatToy) : base(CatSpecies, CatName, CatAge, CatGender, CatSound, CatFood)
        {
            FavouritToy = CatToy;
        }
        public string FavouritToy = "empty";
        public Cat() : base()
        {

        }
        public void PrintFavouritToy()
        {
            Console.WriteLine(AnimalName + "s favorit toy is " + FavouritToy);
        }
    }
}
