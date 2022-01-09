using System;
using System.Security.Cryptography.X509Certificates;

namespace COMS201_LAB_03
{
    class Program
    {
        static void Main()
        {
            // Ask the user for his/her name and instantiate a generic Person object.
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            Person user = new Person() { Name = username };
            Console.WriteLine();

             
            // Test Author, LibraryPatron, and LibraryBook
            Author tolkien = new Author() { Name = "J.R.R. Tolkien" };
            LibraryPatron claire = new LibraryPatron("Claire Roberts", "P101", DateTime.Now);
            LibraryBook hobbit = new LibraryBook() { 
                Title = "The Hobbit", 
                Author = tolkien, 
                CatalogNumber = "A100", 
                Subject = Book.Topic.History 
            };
            hobbit.CheckOut(claire);
            Console.WriteLine();
            hobbit.CheckIn();
            Console.WriteLine();

            // Test Author and TextBook
            Author isaac = new Author() { Name = "Isaac Abraham" };
            Textbook fSharpBook = new Textbook() {
                Title = "Get Programming With F#",
                Author = isaac,
                Subject = Book.Topic.ComputerScience, ListPrice = 65.00
            };

            // user is a Person object. 
            // The Buy method takes a Person object as its parameter.
            fSharpBook.Buy(user);
            Console.WriteLine();
            fSharpBook.Sell(72.50);
            Console.WriteLine();

            // isaac is an Author object, but since Author is a type 
            // of Person isaac can also be used as the parameter for 
            // the TextBook.Buy method. 
            // This is an example of Liskov's Substitution Principle.
            fSharpBook.Buy(tolkien);
            Console.WriteLine();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
