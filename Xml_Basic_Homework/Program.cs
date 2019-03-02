using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_Basic_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Прочитать содержимое XML файла со списком последних новостей по ссылке "https://habrahabr.ru/rss/interesting/"*/

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("https://habrahabr.ru/rss/interesting/");

            var rootElement = xmlDocument.DocumentElement;

            /*Создать класс Item со свойствами: Title, Link, Description, PubDate.
            Создать коллекцию типа List<Item> и записать в нее данные из файла.*/

            XmlNodeList xmlItemTitle = rootElement.GetElementsByTagName("title");
            XmlNodeList xmlItemLink = rootElement.GetElementsByTagName("link");
            XmlNodeList xmlItemDescription = rootElement.GetElementsByTagName("description");
            XmlNodeList xmlItemPubDate = rootElement.GetElementsByTagName("pubDate");

            int itemNumber = 20;

            List<Item> items = new List<Item>(itemNumber);
            

            for (int i = 2; i < xmlItemTitle.Count; i++)
            {
                items.Add(new Item { Title = xmlItemTitle[i].InnerText });
                
            }


            for (int i = 2; i < xmlItemLink.Count; i++)
            {
                items.Add(new Item { Link = xmlItemLink[i].InnerText });
            }


            for (int i = 1; i < xmlItemDescription.Count; i++)
            {
                items.Add(new Item { Description = xmlItemDescription[i].InnerText });
            }


            for (int i = 1; i < xmlItemPubDate.Count; i++)
            {
                items.Add(new Item { PubDate= xmlItemPubDate[i].InnerText });
            }

            foreach (Item item in items)
            {
                Console.WriteLine(item.Title+
                    "\n"+item.Link +
                    "\n" + item.Description+
                    "\n" + item.PubDate);
            }

            Console.ReadLine();
        }
    }
}
