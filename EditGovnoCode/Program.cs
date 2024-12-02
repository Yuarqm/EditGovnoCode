using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditGovnoCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
            Dictionary<string, int> words = WordFrequency(text);

            foreach (var item in words.OrderByDescending(x => x.Value))//сделал рабочую сортировку по кол-ву значений   P.S.не до конца понял тему лямбда-выражения 
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadLine();
        }

        static Dictionary<string, int> WordFrequency(string text)
        {
            string[] words = text.ToLower().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries); //разбил слова чтобы не было лишних символов и чтобы не было пустых элиментов сразу удалил их
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var word in words)//данный цикл является наиболее подходящем для читабельности и производительности
            {
                if (result.ContainsKey(word))
                {
                    result[word]++; // убрал не красивый счетчик
                }
                else
                {
                    result.Add(word, 1);
                }
            }
            // тут ваще бесполезно было
            return result;
        }

    }
}

