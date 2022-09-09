public class Planet
{
    public string Name { get; }
    public int NumberFromSun { get; }
    public int EquatorLength { get; }

    public Planet PrevPlanet { get; }

    public Planet(string name, int numberFromSun, int equatorLength, Planet prevPlanet)
    {
        this.Name = name;
        this.NumberFromSun = numberFromSun;
        this.EquatorLength = equatorLength;
        this.PrevPlanet = prevPlanet;
    }
}