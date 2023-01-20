namespace WordCloud
{
    class Print
    {
       // here is a comment
        public static Dictionary<string, int> parseWords(string text)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            char[] punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();

            IEnumerable<string> words = text.Split().Select(x => x.Trim(punctuation).ToLower());

            words.ToList().ForEach(x =>
            {
                if (x.Length > 2)
                {
                    if (map.ContainsKey(x))
                        map[x]++;
                    else map.Add(x, 1);
                }
            });

            map.ToList().ForEach(x => Console.WriteLine($"name: '{x.Key}', count: {x.Value}"));

            return map;
        }
    }
}
