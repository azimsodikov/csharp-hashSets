using System;
using System.Collections.Generic;


namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Honda");
            Showroom.Add("Tesla");
            Showroom.Add("Toyota");
            Showroom.Add("Mercedez");
            // Console.Write($"There are {Showroom.Count} cars in the Showroom");
            Showroom.Add("Mercedez");
            Console.Write($"There are {Showroom.Count} cars in the Showroom");
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Buggatti");
            UsedLot.Add("Ferrari");
            Showroom.UnionWith(UsedLot);
            Console.Write($"There are now {Showroom.Count} cars in the Showroom");
            Showroom.Remove("Ferrari");
            Console.Write($"I sold one car and There are now {Showroom.Count} cars in the Showroom");
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Buggatti");
            Junkyard.Add("Ferrari");
            Junkyard.Add("Honda");
            Junkyard.Add("Lambo");
            Junkyard.IntersectWith(Showroom);
            foreach (string car in Junkyard)
            {
                Console.WriteLine(car);
            }
            Junkyard.UnionWith(Showroom);
            Junkyard.Remove("Honda");
        }
    }
}
