using System;
using System.Collections.Generic;
using System.Text;

namespace StructOrClass
{
    enum ClassStanding { Freshman, Sophomore, Junior, Senior, Graduate, Other }
    class StudentClass
    {
        public ClassStanding Level { get; set; }
    }
    struct StudentStructure
    {
        public ClassStanding Level { get; set; }
    }
}
