using System.Xml;

namespace WordCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("C:\\Users\\marcus.legault\\source\\repos\\WordCloud\\WordCloud\\textdoc.txt");

            Print.parseWords(text);
        }
    }
}