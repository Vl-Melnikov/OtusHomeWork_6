﻿using System;

namespace Program1_AnonTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var planets = new AnonTypesPlanets();

            planets.GetPlanets();

            Console.ReadKey();
        }
    }
}