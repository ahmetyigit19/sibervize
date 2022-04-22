using System;
using System.IO;
using System.Xml;


namespace siberodev
{
    class Program
    {
        private static readonly Stream program;

        static void Main(string[] args)  //burada çıktıyı okutmaya çalıştım
        {

            string xmltemp = @"temp.xml";
            XmlTextReader Xmltemp = new XmlTextReader(xmltemp);

            while (Xmltemp.Read())
            {
                if (Xmltemp.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine("Etiket: {0} İçerik: {1}", Xmltemp.Name, Xmltemp.ReadElementContentAsString());
                }
            }

            Xmltemp.Close();



            XmlWriter xmlYazici = XmlWriter.Create(xmltemp);  // burada çıktıyı yazdırmaya çalıştım

            xmlYazici.WriteStartDocument();

            xmlYazici.WriteStartElement("etiket");
            xmlYazici.WriteString("Etiket içeriği");
            xmlYazici.WriteEndElement();

            xmlYazici.WriteEndDocument();
            xmlYazici.Close();



        }
    }
}
