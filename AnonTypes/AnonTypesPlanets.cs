using System;

internal class AnonTypesPlanets
{
    public void GetPlanets()
    {
        var venus_1 = new
        {
            Name = "Venus",
            Number = 2,
            EquatorLength = 38025,
        };
        var earth = new
        {
            Name = "Earth",
            Number = 3,
            EquatorLength = 40075,
            PreviousPlanet = venus_1,
        };
        var mars = new
        {
            Name = "Mars",
            Number = 4,
            EquatorLength = 21344,
            PreviousPlanet = earth,
        };
        var venus_2 = new
        {
            Name = "Venus",
            Number = 2,
            EquatorLength = 38025,
            PreviousPlanet = mars,
        };

        Console.WriteLine($"Информация о планете:\n{venus_1}\n{(venus_1.Equals(venus_1) ? "Эквивалентна Венере" : "Не эквивалентна Венере")}\n--------");
        Console.WriteLine($"Информация о планете:\n{earth}\n{(earth.Equals(venus_1) ? "Эквивалентна Венере" : "Не эквивалентна Венере")}\n--------");
        Console.WriteLine($"Информация о планете:\n{mars}\n{(mars.Equals(venus_1) ? "Эквивалентна Венере" : "Не эквивалентна Венере")}\n--------");
        Console.WriteLine($"Информация о планете:\n{venus_2}\n{(venus_2.Equals(venus_1) ? "Эквивалентна Венере" : "Не эквивалентна Венере")}\n--------");
    }
}