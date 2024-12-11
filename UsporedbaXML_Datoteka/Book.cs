using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsporedbaXML_Datoteka
{
    internal class Book
    {
         int BookID;
        string Name;
         double Image;

        public Book(int bookID, string name, double image)
        {
            BookID = bookID;
            Name = name;
            Image = image;
        }

        public int BookID1 { get => BookID; set => BookID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public double Image1 { get => Image; set => Image = value; }
    }
}
