using System;

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
            bool flag = false;
            Console.WriteLine("Напишите пароль");
            string password = Console.ReadLine();
            string symbols = "!@#$%^&*";
            string letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string digits = "0123456789";

            while (flag != true)
            {
                int symbolsCount = 0;
                int lettersCount = 0;
                int digitsCount = 0;
                symbolsCount = Count(symbolsCount, symbols, password);
                lettersCount = Count(lettersCount, letters, password);
                digitsCount = Count(digitsCount, digits, password);
                if (password.Length < 8)
                {
                    Console.WriteLine("Слишком короткий. Необходимо больше 8 символов");
                }
                if (digitsCount < 1)
                {
                    Console.WriteLine("Не содержит ни одной цифры. Необходима 1 цифра");
                }
                if (lettersCount < 1)
                {
                    Console.WriteLine("Не содержит ни одной заглавной буквы. Необходима 1 заглавная буква.");
                }
                if (symbolsCount < 1)
                {
                    Console.WriteLine("Не содержит ни одного спец знака. Необходим 1 символ из (!@#$%^&*)");
                }
                else
                {
                    flag = true;
                }
                if (flag == true)
                {
                    Console.WriteLine("Надежный пароль!");
                    break;
                }
                password = Console.ReadLine();
            }
        }
    }
}
