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
            int digit = int.Parse(digitInput);
            while (secretDigit != digit)
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
                digit = int.Parse(digitInput);
            }
            Console.WriteLine("Вы угадали!");
        }
    }
}
