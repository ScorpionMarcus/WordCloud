using System.Xml;

namespace WordCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph1 = "At Scorpion, we have the technology to connect all of your marketing and show you the results you expect from the money you spend. From our research and customer management software to our artificial intelligence-led search engine products, we have the latest technology to grow your business.";
            string paragraph2 = "Once the technology is in place, our team of specialists will partner with you along the way to handle all of the marketing for your business, so you can focus on providing a great experience to your customers.";

            Print.parseWords(paragraph1);
            Print.parseWords(paragraph2);
        }
    }
}