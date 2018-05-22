using System;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("How many minutes have you exercised today: ");
                
                string entry = Console.ReadLine();
                
                if (entry == "quit")
                {
                    
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        int minutes = int.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Thats a good start, next time try 15 minutes.");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Thats great!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You reached the peak and kept going!");
                        }
                        else
                        {
                            Console.WriteLine("Your going to pull something!");
                        }
                        runningTotal = runningTotal + minutes;

                        Console.WriteLine("You've exercised " + runningTotal + " minutes");
                        Console.WriteLine("\nType \"quit\" to exit");

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The entry is not a valid input.");
                        continue;
                    }
                   

                    
                }


                


            } 
        }
    }
}
