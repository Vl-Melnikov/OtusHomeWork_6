public class Planet
{
    public string Name { get; }
    public int NumberFromSun { get; }
    public int EquatorLength { get; }

    public Planet PrevPlanet { get; }

    public Planet(string name, int numberFromSun, int equatorLength, Planet prevPlanet)
    {
        Name = name;
        NumberFromSun = numberFromSun;
        EquatorLength = equatorLength;
        PrevPlanet = prevPlanet;
    }
}