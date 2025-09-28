using System;
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы в системе Фаренгейта");
            string degreesCInput = Console.ReadLine();
            double degreesC = Convert.ToInt32(degreesCInput);
            double degreesF = (degreesC * 1.8) + 32;
            Console.WriteLine($"{degreesC}°C = {degreesF}°F");
        }
    }
}
