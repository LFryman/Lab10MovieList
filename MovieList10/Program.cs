using System;
using System.Collections.Generic;

namespace MovieList10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>()
            {
            new Movie("Lord of The Rings", "fantacy"),
            new Movie("The Matrix", "action"),
            new Movie("Star Wars", "fantacy"),
            new Movie("Princess Bride", "action"),
            new Movie("Star Trek", "scifi"),
            new Movie("Howells Moving Castle", "animation"),
            new Movie("Spirited Away", "animation"),
            new Movie("Star Gate", "scifi"),
            new Movie("Serenity", "scifi"),
            new Movie("Saving Private Ryan", "action")
            };
            bool lContinue = true;
            while (lContinue)
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are ten movies on this list to chose from.");
                Console.WriteLine("Please enter your desired category.");
                Console.WriteLine("1.) Fantacy.");
                Console.WriteLine("2.) Action.");
                Console.WriteLine("3.) Sci-Fi.");
                Console.WriteLine("4.) Animation.");

                try
                {
                    string userInput = Console.ReadLine();
                    int userInput1 = int.Parse(userInput);

                    if (userInput1 > 0 && userInput1 < 5)
                    {
                        if (userInput1 == 1)
                        {
                            foreach (Movie title in movies)
                            {
                                if (title.Catagory == "fantacy")
                                {
                                    title.Print();
                                }
                            }
                        }
                        else if (userInput1 == 2)
                        {
                            foreach (Movie title in movies)
                            {
                                if (title.Catagory == "action")
                                {
                                    title.Print();
                                }
                            }
                        }
                        else if (userInput1 == 3)
                        {
                            foreach (Movie title in movies)
                            {
                                if (title.Catagory == "scifi")
                                {
                                    title.Print();
                                }
                            }
                        }
                        else if (userInput1 == 4)
                        {
                            foreach (Movie title in movies)
                            {
                                if (title.Catagory == "animation")
                                {
                                    title.Print();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I highly suggest a number from 1 - 4. Try again.");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("That input was not a number");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();

                }

                Console.WriteLine("Would you like to pick another one? y/n");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {
                    lContinue = true;
                }
                else
                {
                    lContinue = false;
                    Console.WriteLine("Come again!");
                }
            }
        }
    }
}


