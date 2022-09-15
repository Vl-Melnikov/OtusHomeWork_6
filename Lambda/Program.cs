using System;

namespace Program3_Lambda
{
    internal class Program
    {
        private static int _countCall;

        public static string PlanetValidator(string name)
        {
            string message;
            _countCall++;

            if (_countCall == 3)
            {
                message = "Вы спрашиваете слишком часто";
                _countCall = 0;
                return message;
            }

            if (name.Equals("Лимония"))
            {
                message = "Это запретная планета";
                return message;
            }

            return null;
        }

        private static void Main(string[] args)
        {
            PlanetCatalog planetCatalog = new PlanetCatalog();

            var (NumberFromSunEarth, EquatorLengthEarth, messageEarth) = planetCatalog.GetPlanet("Земля", PlanetValidator);
            var (NumberFromSunLim, EquatorLengthLim, messageLim) = planetCatalog.GetPlanet("Лимония", PlanetValidator);
            var (NumberFromSunMars, EquatorLengthMars, messageMars) = planetCatalog.GetPlanet("Марс", PlanetValidator);
            var (NumberFromSunMars_1, EquatorLengthMars_1, messageMars_1) = planetCatalog.GetPlanet("Марс", PlanetValidator);

            if (string.IsNullOrEmpty(messageEarth))
            {
                Console.WriteLine(
                    $"Планета Земля\nПорядковый номер от солнца: {NumberFromSunEarth}\nДлина экватора: {EquatorLengthEarth}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Земля\n{messageEarth}\n----------");
            }

            if (string.IsNullOrEmpty(messageLim))
            {
                Console.WriteLine(
                    $"Планета Лимония\nПорядковый номер от солнца: {NumberFromSunLim}\nДлина экватора: {EquatorLengthLim}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Лимония\n{messageLim}\n----------");
            }

            if (string.IsNullOrEmpty(messageMars))
            {
                Console.WriteLine(
                    $"Планета Марс\nПорядковый номер от солнца: {NumberFromSunMars}\nДлина экватора: {EquatorLengthMars}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Марс\n{messageMars}\n----------");
            }

            if (string.IsNullOrEmpty(messageMars_1))
            {
                Console.WriteLine(
                    $"Планета Марс\nПорядковый номер от солнца: {NumberFromSunMars_1}\nДлина экватора: {EquatorLengthMars_1}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Марс\n{messageMars_1}\n----------");
            }
        }
    }
}