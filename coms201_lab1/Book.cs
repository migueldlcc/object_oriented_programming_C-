using System;
using System.Collections.Generic;
using System.Text;

namespace coms201_lab_1
{
    class Book
    {
        private readonly string _isbn;
        private string _title;
        public string Author { get; set; }

        public string Title
        {
            get { return _title; }
        }
        public string Isbn
        {
            get { return _isbn; }
        }
        public void AskUserForTitle()
        {
            Console.Write($"What is the title of the book with {Isbn}? ");
            _title = Console.ReadLine();
        }
        
        public Book(string id)
        {
            _isbn = id;
        }

        public Book (string number, string name)
        {
            _isbn = number;
            _title = name;
        }
    }
}
