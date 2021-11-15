using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCatHouse
{
    public class Cats : Info
    {

        public Cats(string catName, int catAge, string catBreed)
        {
            Name = catName;
            Age = catAge;
            Breed = catBreed;
        }


        //public static DateTime today = DateTime.Today;
        //public static DateTime followup = DateTime.Now.AddDays(30);
        

        //public static void Checkup()
        //{
            //Console.WriteLine($"If you adopted a cat today on {today} then we would need to do an in home check on {followup}");
        //}





        // public static void PerfectMatch()
        //{
        //Console.WriteLine("Name a quality you would like in a pet");
        //string match = Console.ReadLine();
        //Console.WriteLine($"You would like your new best friend to be {match}?");
        //}

        //public static void AdoptionEvent()
        //{
        //var today = DateTime.Now;
        //var saturday = today.AddDays(7);
        //Console.WriteLine("The next adoption event will be hosted ");
        //Console.WriteLine(saturday.ToLongDateString());
        //}

    }
}
