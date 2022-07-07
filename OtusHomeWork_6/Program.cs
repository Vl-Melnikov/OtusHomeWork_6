///*
// * Программа 1 - анонимные типы, их вывод в консоль, сравнение между собой
// */
//var planets = new AnonTypesPlanets();

//planets.GetPlanets();
//Console.WriteLine("---");

//Console.ReadKey();

//class AnonTypesPlanets
//{
//    public void GetPlanets()
//    {
//        var planet1 = new
//        {
//            Name = "Venus",
//            Number = 2,
//            EquatorLength = 38025,
//            PreviousPlanet = "Mercury",
//        };
//        Console.WriteLine(planet1 + "Эквивалентна Венере? " + planet1.Equals(planet1));
 
//        var planet2 = new
//        {
//            Name = "Earth",
//            Number = 3,
//            EquatorLength = 40075,
//            PreviousPlanet = planet1.Name,
//        };
//        Console.WriteLine(planet2 + "Эквивалентна Венере? " + planet2.Equals(planet1));

//        var planet3 = new
//        {
//            Name = "Mars",
//            Number = 4,
//            EquatorLength = 21344,
//            PreviousPlanet = planet2.Name,
//        };
//        Console.WriteLine(planet3 + "Эквивалентна Венере? " + planet3.Equals(planet1));

//        var planet4 = new
//        {
//            Name = "Venus",
//            Number = 2,
//            EquatorLength = 38025,
//            PreviousPlanet = "Mercury",
//        };
//        Console.WriteLine(planet4 + "Эквивалентна Венере? " + planet4.Equals(planet1));
//    }

//}