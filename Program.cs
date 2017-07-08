using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>();
            showroom.Add("Honda Civic");
            showroom.Add("Toyota Corolla");
            showroom.Add("Nissan Altima");
            showroom.Add("Chevy Corvette");
            
            showroom.Add("Honda Civic"); /*  */
            
            Console.WriteLine(showroom.Count);
            

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Ford Mustang");
            UsedLot.Add("Acura RX");

            showroom.UnionWith(UsedLot);
            showroom.Remove("Honda Civic");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Toyota Camry");
            Junkyard.Add("Kia Rio");
            Junkyard.Add("Suzuki Forza");
            Junkyard.Add("Chevy Corvette");

            // showroom.IntersectWith(Junkyard);

            showroom.UnionWith(Junkyard);

            showroom.Remove("Chevy Corvette");
            
            foreach(string model in showroom)
            {
                Console.WriteLine(model);
            }

        }
    }
}
