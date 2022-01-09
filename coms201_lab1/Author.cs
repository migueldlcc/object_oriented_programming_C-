using System;
using System.Collections.Generic;
using System.Text;

namespace coms201_lab_1
{
    class Author
    {
        public string Name { get; set; }
        public string YearBorn { get; set; }

        public void AskUserForAuthorsBirthYear()
        {
            Console.Write($"What is the year the Author was born {YearBorn}? ");
            YearBorn = Console.ReadLine();
        }

        public Author(string authorname)
        {
            Name = authorname;
            AskUserForAuthorsBirthYear();
        }

        public Author(string authorname, string yearborn)
        {
            Name = authorname;
            YearBorn = yearborn;
        }

        public static implicit operator string (Author v)
        {
            throw new NotImplementedException();
        }
    }
}
