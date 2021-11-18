using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TheCatHouse
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Cats> cats = new List<Cats>();
            Cats cat1 = new Cats("Barbie", 1, "Russian Blue");
            cats.Add(cat1);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(titleArt);
            Console.WriteLine("");
            Console.WriteLine("Please press 1, 2, or 3 to select and option below");
            Console.WriteLine("");
            Console.WriteLine("1. View list of adoptable cats");
            Console.WriteLine("2. View the number of adoptable kittens.");
            Console.WriteLine("3. View how often we have met our adoption goal.");
            Console.WriteLine("4. Calculate post adoption followup.");
            Console.WriteLine("5. Quit");


            string userselection;
            userselection = Console.ReadLine();


            switch (userselection)
            {
                case "1":
                    Console.Clear();
                    DisplayListOfCats();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(HowManyKittens());
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("For 8 years we have been helping pets find their FURever home.");
                    Console.WriteLine("We aim to adopt out 250 pets or more every year.");
                    Console.WriteLine("Some years we are shy of that goal.");
                    Console.WriteLine("Below is a list of times when we surpassed our goal");
                    Console.WriteLine("");
                    YearlyAdoptionGraph();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    FollowUp();
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Menu();
        }

        //This method stores and displays all available adult cats from the List<Cats>
        public static void DisplayListOfCats()
        {
            Console.WriteLine("Here is the list of our adoptable cats");
            Console.WriteLine("");
            List<Cats> cats = new List<Cats>();
            cats.Add(new Cats("Barbie", 1, "Russian Blue"));
            cats.Add(new Cats("Buttercup", 3, "Siamese"));
            cats.Add(new Cats("Charlie", 5, "Black Domestic Shorthair"));
            cats.Add(new Cats("Darth", 4, "Black Domestic Shorthair"));
            cats.Add(new Cats("Edgar", 2, "Maine Coon"));
            cats.Add(new Cats("Flora", 4, "Tabby Domestic Shorthair"));
            foreach (var cat in cats)
            {
                Console.WriteLine($"Name: {cat.Name}\nAge: {cat.Age}\nDescription: {cat.Breed}");
                Console.WriteLine("");
            }
        }

        //This method returns total number of kittens available for adoption
        public static int HowManyKittens()
        {
            Console.WriteLine("The number below reflects the number of kittens we currently have available for adoption.");
            IEnumerable<string> items = new List<string> { "Abel", "Bettie", "Carlisle", "Domino", "Edsel", "Finneas", "Gaia" };
            int count = items.Count();
            return count;
        }


        //This method takes the user's adoption date and calculates the followup
        public static void FollowUp()
        {
            Console.WriteLine("We request a brief followup after every pet adoption. Enter the adoption date to calculate your followup.");
            DateTime adoptionDate;
          
            if (DateTime.TryParse(Console.ReadLine(), out adoptionDate))
            {
                Console.WriteLine("The followup will be " + adoptionDate.AddDays(21));
            }
            else
            {
                Console.WriteLine("That is not a correctly formatted date");
            }
        }


        //This method is used to store the total number of adoptions each year and return instances when totalAdoptions exceeded 250
        public static void YearlyAdoptionGraph()
        {
            // Total number of adopted out animals from each year since start of The Cat House
            int[] totalAdoptions = new int[] { 57, 92, 255, 243, 288, 305, 297, 317 };

            IEnumerable<int> yearlyAdoptions =
                from num in totalAdoptions
                where num > 250
                select num;

            foreach (int i in yearlyAdoptions)
            {
                Console.Write(i + " ");
            }
        }
    
        

        
        public static string titleArt = @"
 _____ _            _____       _     _   _                      
|_   _| |          /  __ \     | |   | | | |                     
  | | | |__   ___  | /  \/ __ _| |_  | |_| | ___  _   _ ___  ___ 
  | | | '_ \ / _ \ | |    / _` | __| |  _  |/ _ \| | | / __|/ _ \
  | | | | | |  __/ | \__/\ (_| | |_  | | | | (_) | |_| \__ \  __/
  \_/ |_| |_|\___|  \____/\__,_|\__| \_| |_/\___/ \__,_|___/\___|
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
                                                                 
";
      
        
    }

}
