using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WordCloud
{
    class Print
    {
        public static Dictionary<string, int> parseWords(string word)
        {
            Dictionary<string, int> wordDict = new Dictionary<string, int>();

            var punctuation = word.Where(Char.IsPunctuation).Distinct().ToArray();

            var words = word.Split().Select(x => x.Trim(punctuation).ToLower());

            foreach (var i in words)
            {
                if (i.Length > 2)
                {
                    if (wordDict.ContainsKey(i))
                    {
                        wordDict[i]++;

                    }
                    else
                    {
                        wordDict.Add(i, 1);
                    }
                }
            }

            wordDict.ToList().ForEach(x => Console.WriteLine($"name: '{x.Key}', count: {x.Value}"));

            return wordDict;
        }
    }
}
