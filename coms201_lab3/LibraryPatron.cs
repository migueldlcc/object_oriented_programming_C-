using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace COMS201_LAB_03
{
    class LibraryPatron: Person
    {
        public readonly string CardNumber;
        public readonly DateTime MemberSince;

        public LibraryPatron(string name, string cardnumber, DateTime membersince)
        {
            Name = name;
            CardNumber = cardnumber;
            MemberSince = membersince;
        }
    }
}
