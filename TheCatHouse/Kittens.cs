using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TheCatHouse
{
    public class Kittens
    {
        public string Gender;
        public int AdoptionFee;
        public string KittenName;




        public Kittens(string kittenName, int TheAdoptionFee, string TheGender)
        {
            this.KittenName = kittenName;
            this.AdoptionFee = TheAdoptionFee;
            this.Gender = TheGender;



            Kittens kitten = new Kittens("Buttercu", 50, "male");
            Kittens kitten2 = new Kittens("Mocha", 50, "male");
            Kittens kitten3 = new Kittens("Peanut", 50, "male");

        }
        public bool IsAKitten()
        {
            if (AdoptionFee > 50)
            {
                return true;
            }
            return false;
        }

       // public int CalculateAdoptionFee(int a, int b)
       // {
            //AdoptionFee = a;
           // b = 25; 
           // return a * b;
       // }
    }
}
