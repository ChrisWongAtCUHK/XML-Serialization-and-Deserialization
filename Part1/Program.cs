using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreetName = "Rohini";
            details.City = "Delhi";
            Serialize(details);
        }

        static public void Serialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter(@"Xml.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
    }
}
