using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace UsporedbaXML_Datoteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string prviXml = @"<Books>
     <book id='1' image='C01' name='C# in Depth'/>
     <book id='2' image='C02' name='ASP.NET'/>
     <book id='3' image='C03' name='LINQ in Action '/>
     <book id='4' image='C04' name='Architecting Applications'/>

    </Books>";

            string drugiXml = @"<Books>
     <book id='1' image='C011' name='C# in Depth'/>
     <book id='2' image='C02' name='ASP.NET 2.0'/>
     <book id='3' image='XXXC03' name='XXXLINQ in Action '/>
     <book id='4' image='C04' name='Architecting Applications'/>
    <book id='5' image='C05' name='PowerShell in Action'/>

    </Books>";

          

            XDocument xdoc = new XDocument(new XElement("Books",
     from newBook in XDocument.Parse(prviXml).Descendants("book")
     join oldBook in XDocument.Parse(drugiXml).Descendants("book")
         on newBook.Attributes("id").First().Value equals oldBook.Attributes("id").First().Value into oldBooks
     where !oldBooks.Any()
             || newBook.Attributes().Any(a => a.Value != oldBooks.First().Attributes(a.Name).First().Value)
     select newBook));
        }
    }
}
