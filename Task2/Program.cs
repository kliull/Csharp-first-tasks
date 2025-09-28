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
            while (digitInput != "0")
            {
                int digit = int.Parse(digitInput);
                sum += digit;
                Console.WriteLine($"Текущая сумма: {sum}");
                Console.WriteLine("Введите число. Если захотите остановить программу введите 0");
                digitInput = Console.ReadLine();
            }
        }
    }
}
