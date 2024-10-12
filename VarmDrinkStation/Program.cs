using System;
using System.Collections.Generic;
using System.Linq;

namespace VarmDrinkStation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newOrder = true;

            while (newOrder)
            {
                Console.Clear();
                var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine
                IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
                drink.Consume(); // Konsumerar drycken
                Console.WriteLine("");
                Console.WriteLine("Press any key to add a new drink or X to exit:");
                
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "x")
                {
                    newOrder = false;
                                        
                }
            }
            Console.WriteLine("Thank you and Have a great day!");
        }
    }
}
