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

        public static void DisplayList()
        {
            Console.WriteLine("Here is the list of our adoptable cats");
            Console.WriteLine("");
            List<Cats> cats = new List<Cats>();
            cats.Add(new Cats("Barbie", 1, "White"));
            cats.Add(new Cats("Buttercup", 3, "Siamese"));
            cats.Add(new Cats("Charlie", 5, "Black"));
            cats.Add(new Cats("Darth", 4, "Black"));
            cats.Add(new Cats("Edgar", 2, "Black"));
            cats.Add(new Cats("Flora", 4, "Black"));

            foreach (var cat in cats)
            {
                Console.WriteLine($"Name:  {cat.Name}  Age:  {cat.Age}   Breed:  {cat.Breed}");
            }
        }




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
