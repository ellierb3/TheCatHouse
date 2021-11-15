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
            Console.WriteLine("2. Filler");
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
                    //Cats.AdoptionEvent();
                    Cats.Checkup();
                    Console.WriteLine("Filler text");
                    Console.ReadLine();
                   
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("********************Goodbye********************");
                    Console.WriteLine("");
                    Console.WriteLine("**********Press any key to go back to the main menu**********");
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
                Console.WriteLine($"Name:  {cat.Name}  Age:  {cat.Age}   Breed:  {cat.Breed}");
            }
        }

        
        //bool exists = cats.Any(x => x.Age == 2);
        //public static string BlackCats()
        //{
            //foreach(string item in cats)
            //{
                //if (item.Contains("Black"))
                //{
                    //return item;
                //}
            //}
        //}


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
