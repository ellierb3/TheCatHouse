using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TheCatHouse
{
    class Program
    {
        public static List<Cats> cats = new List<Cats>();
        
        

        static void Main(string[] args)
        {
            
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
            Console.WriteLine("2. Filler Text");
            Console.WriteLine("3. Quit");
            
            

            string userselection;
            userselection = Console.ReadLine();


            switch (userselection)
            {
                case "1":
                    Console.Clear();
                    DisplayList();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    //DoesIt();
                    //Console.WriteLine(Cats.myAge.Days);
                    //GetKitten();
                    Console.WriteLine(KindOfCat());
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    //Console.WriteLine("********************Goodbye********************");
                    //Console.WriteLine("");
                    //Console.WriteLine("**********Press any key to go back to the main menu**********");
                    Console.WriteLine(Example());
                    Console.WriteLine(LastOne());
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

        public static bool KindOfCat()
        {
            if (cats.Exists(x => x.Breed.Contains("Siamese")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string[] GetKitten()
        {
            Kittens susie = new Kittens("Susie", "Female");
            Kittens pete = new Kittens("Pete", "Male");
            Kittens[] kitten =
            {
                susie,
                pete
            };
            string[] gender = kitten.Select(x => x.KittenGender).ToArray();
            return gender;
        }

        


        public static void DoesIt()
        {
            List<string> kittens = new List<string>();
            kittens.Add("Bettie");
            kittens.Add("Barney");
            kittens.Add("Cathy");

            Console.WriteLine("Type the name you want to search for");
            var sandwich = Console.ReadLine();
            var matchingvalues = kittens.Any(stringToCheck => stringToCheck.Contains(sandwich));
            Console.WriteLine(matchingvalues);
        }

        

        public static int Example()
        {
            IEnumerable<int> items = new List<int> { 8, 3, 2 };
            int count = (from x in items where x < 5 select x).Count();
            return count;
        }
        
        public static int LastOne()
        {
            IEnumerable<string> items = new List<string> { "A", "B", "C" };
            int count = items.Count();
            return count;
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
