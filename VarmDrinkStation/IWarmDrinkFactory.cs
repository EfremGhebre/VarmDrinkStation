using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation
{
    // Definierar ett interface för fabriker som kan skapa varma drycker
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total); // Metod för att förbereda drycken med en specifik mängd
    }

    // Implementerar en specifik fabrik som förbereder varmt vatten
    internal class HotWaterFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot water in your cup"); // Utskrift av mängden vatten som hälls upp
            return new Water(); // Returnerar en ny instans av Water
        }
    }

    internal class WarmChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Your {total} ml warm chocolate is being prepared..."); 
            return new WarmChocolate(); // Returnerar en ny instans av Warm chocolate
        }
    }
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Your {total} ml coffee is being prepared..."); 
            return new Coffee(); // Returnerar en ny instans av Coffee
        }
    }
    internal class CappucinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Your {total} ml cappucino is being prepared...");
            return new Cappucino(); // Returnerar en ny instans av Cappucino
        }
    }
}
