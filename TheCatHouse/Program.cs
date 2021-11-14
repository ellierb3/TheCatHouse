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
                    Cats.DisplayList();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    //Cats.AdoptionEvent();
                    
                    Console.WriteLine("What gender are you looking for?");
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
