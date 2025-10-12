using System;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите число. Если захотите остановить программу введите 0");
            string digitInput = Console.ReadLine();
            int digit;
            while (digitInput != "0")
            {
                bool isDigit = int.TryParse(digitInput, out digit);
                if (isDigit)
                {
                    sum += digit;
                    Console.WriteLine($"Текущая сумма: {sum}");
                    Console.WriteLine("Введите число. Если захотите остановить программу введите 0");
                    digitInput = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                    Console.WriteLine("Введите число. Если захотите остановить программу введите 0");
                    digitInput = Console.ReadLine();
                }
            }
        }
    }
}
