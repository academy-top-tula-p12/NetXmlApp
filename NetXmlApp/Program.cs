using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using NetXmlApp;

XmlDocument document = new XmlDocument();
document.Load("empls.xml");

XmlElement? root = document.DocumentElement;

XmlNodeList? nodes = root?.SelectNodes("//*[title]/ancestor::Employee");
if(nodes is not null)
{
    foreach(XmlNode node in nodes)
        Console.WriteLine(node.OuterXml + "\n");
}
