using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NetXmlApp
{
    internal class XmlDocumentModify
    {
        static public void Example()
        {
            XmlDocument document = new XmlDocument();
            document.Load("empls.xml");

            XmlElement? root = document.DocumentElement;

            XmlElement employee = document.CreateElement("Employee");

            XmlElement name = document.CreateElement("Name");
            XmlText nameText = document.CreateTextNode("Leo");

            XmlAttribute type = document.CreateAttribute("type");
            XmlText typeText = document.CreateTextNode("first");

            name.AppendChild(nameText);
            type.AppendChild(typeText);

            name.Attributes.Append(type);

            employee.AppendChild(name);

            root.AppendChild(employee);

            document.Save("empls.xml");
        }
    }
}
