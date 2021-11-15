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
        public string Gender { get; set; }
        public int AdoptionFee { get; set; }
        public string KittenName{ get; set; }
        



        public Kittens(string KittenName, int AdoptionFee, string Gender)
        {
            Kittens Butter = new Kittens("Butter", 50, "male");
            Kittens Mocha = new Kittens("Mocha", 50, "male");
            Kittens Peanut = new Kittens("Peanut", 50, "male");

        }
        public bool IsAKitten()
        {
            if (AdoptionFee > 40)
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
