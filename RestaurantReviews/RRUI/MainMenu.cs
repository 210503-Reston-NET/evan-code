using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do 
            {
                Console.WriteLine("Welcome to my Restaraunt Reviews Application");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View a restaraunt");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
                switch (input) {
                    case "0":
                        //View a restaurant
                        ViewRestaurant();
                        break;
                    case "1":
                        //exit
                        Console.WriteLine("Goodbye");
                        repeat = false;
                        break;
                    default:
                        //invalid input
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            }
            while (repeat);
        }

        private void ViewRestaurant()
        {
            Restaurant goodTaste = new Restaurant("Good Taste", "Boulder", "Colorado");
            goodTaste.Reviews = new List<Review>
            {
                new Review {
                    Rating = 5,
                    Description = "Amazing"
                },
            };
            Console.WriteLine(goodTaste.ToString());
            foreach (Review review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}