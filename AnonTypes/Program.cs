using System;

namespace AnonTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var planets = new AnonTypesPlanets();

            planets.GetPlanets();
            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}