using System;

namespace coms201_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This first Book object is instantiated using the constructor that only takes the ISBN.
            // In line 17 we are setting the Book object's Author property to a new Author object
            // using the Author constructor that takes only the author's name.
            Console.Write("Please enter an ISBN: ");
            var isbn1 = Console.ReadLine();
            var book1 = new Book(isbn1);
            Console.Write($"Who wrote \"{ book1.Title }\"? ");
            var authorName1 = Console.ReadLine();
            book1.Author = new Author(authorName1);

            // Add two blank lines to the console.
            Console.WriteLine("\n");

            // Now we'll used the overloaded Book constructor which takes both the title and ISBN.
            // And in line 33 we're setting this Book object's Author property to a new Author object
            // using the Authro constructor that takes both the author's name and their birth year.
            Console.Write("Please enter another book title: ");
            var title = Console.ReadLine();
            Console.Write($"Please enter the ISBN for \"{ title }\": ");
            var isbn2 = Console.ReadLine();
            var book2 = new Book(isbn2, title);
            Console.Write($"Who wrote \"{ book2.Title }\"? ");
            var authorName2 = Console.ReadLine();
            Console.Write($"In what year was { authorName2 } born? ");
            var birthYear2 = Console.ReadLine();
            book2.Author = new Author(authorName2, birthYear2);

            // Add two blank lines to the console.
            Console.WriteLine("\n");

            // Display a summary by showing the values of all the Book objects' poerties.
            Console.WriteLine("Okay, here is what I have...\n");
            Console.WriteLine($"The book \"{ book1.Title }\" was written by { book1.Author.Name } who was born in { book1.Author.YearBorn }.\nThis book has ISBN '{ book1.Isbn }'.\n\n");
            Console.WriteLine($"The book \"{ book2.Title }\" was written by { book2.Author.Name } who was born in { book2.Author.YearBorn }.\nThis book has ISBN '{ book2.Isbn }'.\n\n");

            // Wait for the user to press a key before closing the console.
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
