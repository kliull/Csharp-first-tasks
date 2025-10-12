using System;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretDigit = rnd.Next(1, 11);
            Console.WriteLine("Попробуйте отгадать число от 1 до 10 которое я загадал.");
            string digitInput = Console.ReadLine();
            int digit = -5;

            while (secretDigit != digit)
            {
                bool isDigit = int.TryParse(digitInput, out digit);
                if (isDigit)
                {
                    if (secretDigit > digit)
                    {
                        Console.WriteLine(">");
                    }
                    else
                    {
                        Console.WriteLine("<");
                    }
                    digitInput = Console.ReadLine();
                    isDigit = int.TryParse(digitInput, out digit);
                }
                else
                {
                    Console.WriteLine("Вы ввели не число.");
                    digitInput = Console.ReadLine();
                    isDigit = int.TryParse(digitInput, out digit);
                }
            }
            Console.WriteLine("Вы угадали!");
        }
    }
}
