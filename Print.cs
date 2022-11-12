using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCloud
{
    class Print
    {
        public static List<string> parseWords(string word)
        {
            List<string> wordList = new List<string>();
            Dictionary<string, string> wordDict = new Dictionary<string, string>();

            int count = 0;

            // create a variable that contains all punctuation from the paragraph
            var punctuation = word.Where(Char.IsPunctuation).Distinct().ToArray();

            // create an enumerable containing all the words with the punctuation items trimmed out
            var words = word.Split().Select(x => x.Trim(punctuation));

            // loop through words and if a word has length greater than 2 add it to our list
            foreach (var i in words)
            {
                if (i.Length > 2)
                {
                    Console.WriteLine(i.ToLower() + " - " + count);
                    wordDict.Add("name: " + i.ToLower(), "count: " + count);
                    count++;
                }
            }

            return wordList;
        }
    }
}
