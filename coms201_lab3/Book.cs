using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace COMS201_LAB_03
{
    abstract class Book
    {
        public enum Topic
        {
            Biology,
            Chemistry,
            ComputerScience,
            History,
            Mathematics
        }
        public readonly Guid Id = Guid.NewGuid();
        public string Title { get; set; }
        public Author Author { get; set; }
        public Topic Subject { get; set; }

    }
}
