using System;
using System.Collections.Generic;
namespace NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            int maxCountWords = 0;
            int sumLen = 0;
            string[] listWords = str.Split(' ');
            string[] listSentances = str.Split('.');
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
