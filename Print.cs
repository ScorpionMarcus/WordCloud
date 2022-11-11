using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCloud
{
    class Print
    {
        public static void parseWords(string word)
        {
            List<string> wordList = new List<string>();

            var punctuation = word.Where(Char.IsPunctuation).Distinct().ToArray();

            var words = word.Split().Select(x => x.Trim(punctuation));

            foreach (var i in words)
            {
                Console.WriteLine(i);
                wordList.Add(i);
            }

            Console.WriteLine(wordList);
        }
    }
}
