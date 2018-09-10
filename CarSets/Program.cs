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

            Console.WriteLine(Showroom.Count());

            Console.ReadLine();
        }
    }
}
