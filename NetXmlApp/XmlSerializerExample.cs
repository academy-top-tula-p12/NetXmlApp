using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NetXmlApp
{
    class XmlSerializerExample
    {
        static void Example()
        {
            Employee tom = new("Tom", new(1989, 5, 3), "Developer", 90000);

            List<Employee> employees = new()
            {
                new("Bob", new(2000, 2, 15), "Manager", 60000),
                new("Joe", new(1997, 9, 23), "Driver", 50000),
            };

            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

            using (FileStream writer = new("empls.xml", FileMode.OpenOrCreate))
            {
                //serializer.Serialize(writer, tom);
                serializer.Serialize(writer, employees);
            }
        }
    }
}
