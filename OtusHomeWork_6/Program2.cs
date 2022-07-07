///*
// * Программа 2 - кортежи
// */

var planet = new Planet();
planet.inpoutPlanets();

//var planetsCatalog = new PlanetsCatalog();

class Planet
{
    public void inpoutPlanets()
    {
        var planet1 = new PlanetsCatalog("Venus", 2, 38025, "Mercury");
        Console.WriteLine("Обычный класс: " + planet1);
        var planet2 = new PlanetsCatalog("Earth", 3, 40075, planet1.Name);
        Console.WriteLine("Обычный класс: " + planet2);
        var planet3 = new PlanetsCatalog("Mars", 4, 21344, planet2.Name);
        Console.WriteLine("Обычный класс: " + planet3);
    }

    public class PlanetsCatalog
    {
        public PlanetsCatalog(string name, int number, int equatorLength, string previousPlanet)
        {
            Name = name;
            Number = number;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
        public string Name { get; }
        public int Number { get; }
        public int EquatorLength { get; }
        //public PlanetsCatalog? PreviousPlanet { get; }
        public string PreviousPlanet { get; }
        public override string ToString()
        {
            return $"Name={Name}";
        }

        public string GetPlanets()
        {
            return;
        }
    }
}
