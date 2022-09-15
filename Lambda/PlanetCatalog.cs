using System.Collections.Generic;

public class PlanetCatalog
{
    private List<Planet> planetCatalog = new List<Planet>();

    public PlanetCatalog()
    {
        planetCatalog.Add(new Planet("Венера", 2, 38025, null));
        planetCatalog.Add(new Planet("Земля", 3, 40075, planetCatalog[0]));
        planetCatalog.Add(new Planet("Марс", 4, 21344, planetCatalog[1]));
    }

    public (int NumberFromSun, int EquatorLength, string message) GetPlanet(string PlanetName, PlanetValidator planetValidator)
    {
        var result = (NumberFromSun: 0, EquatorLength: 0, message: "");

        result.message = planetValidator(PlanetName);

        foreach (var planet in planetCatalog)
        {
            if (planet.Name.Equals(PlanetName))
            {
                result.NumberFromSun = planet.NumberFromSun;
                result.EquatorLength = planet.EquatorLength;
            }
        }

        if (result.NumberFromSun == 0 && result.message == "")
        {
            result.message = "Не удалось найти планету";
        }

        return result;
    }

    public delegate string PlanetValidator(string Name);
}