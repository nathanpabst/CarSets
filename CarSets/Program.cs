using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Porsche");
            Showroom.Add("Lambo");
            Showroom.Add("Corvette");
            Showroom.Add("Range Rover");
            Showroom.Add("Porsche");

            var showroomCount = Showroom.Count();

            Console.WriteLine($"There are {showroomCount} cars in the Showroom");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Firebird");
            UsedLot.Add("Pinto");

            var usedLotCount = UsedLot.Count();

            Console.WriteLine($"There are {usedLotCount} cars in the Used lot.");

            Showroom.UnionWith(UsedLot);
            var allCarCount = Showroom.Count();
            Console.WriteLine($"There are {allCarCount} cars in total.");

            Showroom.Remove("Pinto");
            var adjustedCount = Showroom.Count();
            Console.WriteLine($"Sales things are happening. Your inventory is now at {adjustedCount} cars.");


            Console.ReadLine();
        }
    }
}
