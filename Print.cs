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
        public static Dictionary<string, int> parseWords(string text)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            char[] punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();

            IEnumerable<string> words = text.Split().Select(x => x.Trim(punctuation).ToLower());

            foreach (var i in words)
            {
                if (i.Length > 2)
                {
                    if (map.ContainsKey(i)) 
                        map[i]++;
                    else map.Add(i, 1);
                }
            }

            map.ToList().ForEach(x => Console.WriteLine($"name: '{x.Key}', count: {x.Value}"));

            return map;
        }
    }
}
