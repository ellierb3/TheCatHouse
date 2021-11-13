using System;
using System.Collections.Generic;
using System.Collections;

namespace TheCatHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(titleArt);
            Console.WriteLine("");
            Console.WriteLine("1. Adoptable Dogs");
            Console.WriteLine("2. Adoptable Cats");
            Console.WriteLine("3. Quit");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please select an option from above");

            string userselection;
            userselection = Console.ReadLine();


            switch (userselection)
            {
                case "1":
                    PerfectMatch();

                    break;
                case "2":
                    int fee = AdoptionCost(3);
                    Console.WriteLine($"The adoption fee for a cat that age would be " + fee + " dollars.");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    DisplayList();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Cats.SortCats();
                    Console.ReadLine();
                    break;
            }
            Menu();
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
                Console.WriteLine($"Name:{cat.Name} Age: {cat.Age} Breed: {cat.Breed}");
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
        public static int AdoptionCost(int catAge)
        {
            Console.WriteLine("To display adoption fees, enter the age of the cat");
            Console.ReadLine();
            int cost = catAge;
            return cost;
        }

        static void PerfectMatch()
        {
            Console.WriteLine("Name a quality you would like in a pet");
            string match = Console.ReadLine();
            Console.WriteLine($"You would like your new best friend to be {match}?");
            
        }
        
    }

}
