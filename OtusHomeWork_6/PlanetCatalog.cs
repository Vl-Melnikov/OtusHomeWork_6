public class PlanetCatalog
{
    private int _countCall;

    private List<Planet> planetCatalog = new List<Planet>();

    public PlanetCatalog()
    {
        planetCatalog.Add(new Planet("Венера", 2, 38025, null));
        planetCatalog.Add(new Planet("Земля", 3, 40075, planetCatalog[0]));
        planetCatalog.Add(new Planet("Марс", 4, 21344, planetCatalog[1]));
    }

    public (int NumberFromSun, int EquatorLength, string message) GetPlanet(string PlanetName)
    {
        var result = (NumberFromSun: 0, EquatorLength: 0, message: "");

        _countCall++;

        if (_countCall == 3)
        {
            result.message = "Вы спрашиваете слишком часто";
            _countCall = 0;
        }

        foreach (var planet in planetCatalog)
        {
            if (planet.Name.Equals(PlanetName))
            {
                result.NumberFromSun = planet.NumberFromSun;
                result.EquatorLength = planet.EquatorLength;
            }
        }

        if (result.NumberFromSun == 0)
        {
            result.message = "Не удалось найти планету";
        }

        return result;
    }
}