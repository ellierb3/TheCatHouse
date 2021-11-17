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
        public string KittenName { get; }
        public string KittenGender { get; }

        public Kittens( string kittyn, string kittyg)
        {
            this.KittenName = kittyn;
            this.KittenGender = kittyg;
        }

        public override string ToString() => $"{KittenName}, {KittenGender}";




        // public int CalculateAdoptionFee(int a, int b)
        // {
        //AdoptionFee = a;
        // b = 25; 
        // return a * b;
        // }

    }
}
