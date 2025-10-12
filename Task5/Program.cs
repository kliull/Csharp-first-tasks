using System;
using System.Collections.Generic;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            int sumLen = 0;
            string symbols = ".,:;)()";
            str = str.Replace("!", ".");
            str = str.Replace("?", ".");
            string[] listSentances = str.Split('.');
            foreach (char element in symbols)
            {
                str = str.Replace(element, " ");
            }
            string[] listWords = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in listWords)
            {
                sumLen += word.Length;
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }
            double midLen = sumLen / listWords.Length;
            string mostFrequent = "Нет самых частых слов";
            int mostFrequentCount = 1;
            foreach (var element in dictionary)
            {
                if (element.Value > mostFrequentCount)
                {
                    mostFrequent = element.Key;
                }
            }
            Console.WriteLine($"Количество слов:{listWords.Length}");
            Console.WriteLine($"Количество предложений:{listSentances.Length}");
            Console.WriteLine($"Самые часто встречающиеся слова:{mostFrequent}");
            Console.WriteLine($"Средняя длина слов:{midLen}");
        }
    }
}
