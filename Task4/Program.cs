using System;
namespace third
{
    class Program
    {
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
                foreach (char element in password)
                {
                    foreach (char symbol in symbols)
                    {
                        if (element == symbol)
                        {
                            symbolsCount += 1;
                        }
                    }
                    foreach (char letter in letters)
                    {
                        if (element == letter)
                        {
                            lettersCount += 1;
                        }
                    }
                    foreach (char digit in digits)
                    {
                        if (element == digit)
                        {
                            digitsCount += 1;
                        }
                    }
                }
                if (password.Length < 8)
                {
                    Console.WriteLine("Слишком короткий. Необходимо больше 8 символов");
                }
                else if (digitsCount < 1)
                {
                    Console.WriteLine("не содержит ни одной цифры. Необходима 1 цифра");
                }
                else if (lettersCount < 1)
                {
                    Console.WriteLine("не содержит ни одной заглавной буквы. Необходима 1 заглавная буква.");
                }
                else if (symbolsCount < 1)
                {
                    Console.WriteLine("не содержит ни одного спец знака. Необходим 1 символ из (!@#$%^&*)");
                }
                else
                {
                    flag = true;
                }
                password = Console.ReadLine();
            }
            Console.WriteLine("Надежный пароль!");
        }
    }
}
