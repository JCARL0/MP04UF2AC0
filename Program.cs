using System.Xml;
namespace RssParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string rssFeedUrl = "https://techcrunch.com/feed/";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rssFeedUrl);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("item");
            foreach (XmlNode node in nodeList)
            {
                string title = node["title"].InnerText;
                Console.WriteLine("titulo: " + title);
                string category = node["category"].InnerText;
                Console.WriteLine("categoria: " + category);
                string link = node["link"].InnerText;
                Console.WriteLine("link: " + link);
                string description = node["description"].InnerText;
                Console.WriteLine("descripcion: " + description);
                string pubDate = node["pubDate"].InnerText;
                Console.WriteLine("lanzamiento: " + pubDate);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}