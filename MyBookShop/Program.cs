// <copyright file="Program.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Program
{
    using System;

    /// <summary>
    /// This is the main program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The method creates the main menu.
        /// </summary>
        public static void MainMenu()
        {
            bool visible = true;

            while (visible)
            {
                Console.WriteLine("C-R-U-D Functions: \n");
                Console.WriteLine(" (1) Create new");
                Console.WriteLine(" (2) Add");
                Console.WriteLine(" (3) Delete");
                Console.WriteLine(" (4) Update");
                Console.WriteLine(" (5) Read");
                Console.WriteLine("\nEXTRA Functions: \n");
                Console.WriteLine(" (5) List the books which were sold in SHOP7");
                Console.WriteLine(" (6) List the authors and their books priced more than 3000");
                Console.WriteLine(" (7) List the books and their genres which got higher rating than 5 \n");
                Console.WriteLine(" (x) Exit \n");
                string userPick = Console.ReadLine();

                switch (userPick)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("This function is not ready yet \n");
                        break;
                    case "x":
                        Console.Clear();
                        visible = false;
                        break;
                    default:
                        throw new SystemException();
                }
            }
        }

        private static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
