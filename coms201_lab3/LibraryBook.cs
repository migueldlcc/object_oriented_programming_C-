using System;
using System.Collections.Generic;
using System.Text;

namespace COMS201_LAB_03
{
    class LibraryBook: Book
    {
        public string CatalogNumber { get; set; }
        public bool Available { get; set; }
        public LibraryPatron Holder { get; set; }

        public void CheckOut(LibraryPatron librarypatron)
        {
            Holder = librarypatron;
            Available = false;
            Console.WriteLine($" \"{Title}\" was checked out by \"{Holder.Name}\" ");
        }

        public void CheckIn()
        {
            Holder = null;
            Available = true;
            Console.WriteLine($"\"{Title}\" has been checked in");
        }
    }
}
