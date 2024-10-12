using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation
{
    // Definierar ett interface för varma drycker
    public interface IWarmDrink
    {
        void Consume(); // Metod för att konsumera drycken        
    }

    // Implementerar en specifik varm dryck, i detta fall vatten
    internal class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warm water is served."); // Utskrift vid konsumtion av vatten
            Console.ResetColor();
        }
    }

    internal class WarmChocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm chocolate is ready.");
        }
    }

    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is ready.");
        }
    }
    
    internal class Cappucino: IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Cappucino is ready.");
        }
    }
}
