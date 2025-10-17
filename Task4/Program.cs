﻿using System;

namespace third
{
    class Program
    {
        static int Count(int countSymb, string listSymb, string password)
        {
            foreach (char element in password)
            {
                foreach (char symbol in listSymb)
                {
                    if (element == symbol)
                    {
                        countSymb += 1;
                    }
                }
            }
            return countSymb;
        }
        static void Main(string[] args)
        {
            int flagcount = 0;
            Console.WriteLine("Напишите пароль");
            string password = Console.ReadLine();
            string symbols = "!@#$%^&*";
            string letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string digits = "0123456789";

            while (flagcount != 4)
            {
                int symbolsCount = 0;
                int lettersCount = 0;
                int digitsCount = 0;
                flagcount = 4;
                symbolsCount = Count(symbolsCount, symbols, password);
                lettersCount = Count(lettersCount, letters, password);
                digitsCount = Count(digitsCount, digits, password);
                if (password.Length < 8)
                {
                    Console.WriteLine("Слишком короткий. Необходимо больше 8 символов");
                    flagcount -= 1;
                }
                if (digitsCount < 1)
                {
                    Console.WriteLine("Не содержит ни одной цифры. Необходима 1 цифра");
                    flagcount -= 1;
                }
                if (lettersCount < 1)
                {
                    Console.WriteLine("Не содержит ни одной заглавной буквы. Необходима 1 заглавная буква.");
                    flagcount -= 1;
                }
                if (symbolsCount < 1)
                {
                    Console.WriteLine("Не содержит ни одного спец знака. Необходим 1 символ из (!@#$%^&*)");
                    flagcount -= 1;
                }
                if (flagcount == 4)
                {
                    Console.WriteLine("Надежный пароль!");
                    break;
                }
                password = Console.ReadLine();
            }
        }
    }
}
