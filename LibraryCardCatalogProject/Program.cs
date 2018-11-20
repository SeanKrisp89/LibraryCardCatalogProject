using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LibraryCardCatalogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your local library online catalog.");
            Console.WriteLine();
            Console.Write("Please enter a file name: "); // This somehow needs to get stored in the CardCatalog class. Call CardCatalog?
            string fname = Console.ReadLine();
            CardCatalog first = new CardCatalog(fname);
            Console.WriteLine();
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }           
        }

        private static bool MainMenu() // Displays main menu
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine();
            Console.WriteLine("1: List All Books");
            Console.WriteLine("2: Add a Book");
            Console.WriteLine("3: Save & Exit");
            string result = Console.ReadLine();
            if (result == "1") // This will display all book objects
            {
                return true; // This will continue displaying the menu even after they've accessed the List All Books functionality
            }
            else if (result == "2") // This will take the user to Add a Book functionlity
            {
                return true; // This will continue displaying the menu even after they've accessed the Add a Book funtionality
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
