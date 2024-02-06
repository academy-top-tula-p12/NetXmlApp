using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NetXmlApp
{
    internal class XmlDocumentPrint
    {
        static void Example()
        {
            XmlDocument document = new XmlDocument();
            document.Load("empls.xml");

            XmlElement? root = document.DocumentElement;

            if (root is not null)
            {
                Console.WriteLine($"Root name: {root.Name}");
                Console.WriteLine($"Inner text: {root.InnerText}");
                Console.WriteLine($"Inner xml: {root.InnerXml}\n");

                //Console.WriteLine("Nodes:");
                //foreach (XmlNode node in root.ChildNodes)
                //{
                //    Console.WriteLine($"Node: {node.Name}");
                //}

                Console.WriteLine("\nElements:");
                ElementsPrint(root);

                //foreach (XmlElement element in root)
                //{
                //    Console.WriteLine($"\nElement: {element.Name}");

                //    Console.WriteLine($"\tAttributes:");
                //    foreach (XmlAttribute attribute in element.Attributes)
                //        Console.WriteLine($"\t\t{attribute.Name}={attribute.Value}");

                //    foreach(XmlElement innerElement in element)
                //    {
                //        Console.WriteLine($"\n\tElement: {innerElement.Name}");

                //        Console.WriteLine($"\t\tAttributes:");
                //        foreach (XmlAttribute attribute in innerElement.Attributes)
                //            Console.WriteLine($"\t\t\t{attribute.Name}={attribute.Value}");
                //    }
                //}

            }

            void ElementsPrint(XmlElement element, int level = 0)
            {
                string tabs = new String('\t', level);

                Console.WriteLine();

                Console.WriteLine($"{tabs}Element: {element.Name}");
                Console.WriteLine($"{tabs}Value: {element.InnerText}");

                Console.WriteLine($"{tabs}Attributes:");
                foreach (XmlAttribute attribute in element.Attributes)
                    Console.WriteLine($"{tabs}{attribute.Name}={attribute.Value}");

                foreach (XmlNode node in element)
                {
                    if (node.NodeType == XmlNodeType.Element)
                        ElementsPrint((node as XmlElement)!, level + 1);
                }

            }
        }
    }
}
