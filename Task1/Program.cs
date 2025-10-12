using System;
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы в системе Цельсия");
            string degreesCInput = Console.ReadLine();
            int degreesC;
            bool isCorrect = int.TryParse(degreesCInput, out degreesC);
            if (isCorrect)
            {
                double degreesF = (degreesC * 1.8) + 32;
                Console.WriteLine($"{degreesC}°C = {degreesF}°F");
            }
            else
                Console.WriteLine("Вы ввели не число");
        }
    }
}
