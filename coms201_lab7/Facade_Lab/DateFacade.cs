using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Lab
{
    public static class DateFacade
    {
        static DateTime StartOfWeek
        {
            get { return Concepts2Code.DateUtilities.GetStartOfCurrentWeek(); }
        }
        static DateTime EndOfWeek
        {
            get { return Concepts2Code.DateUtilities.GetEndOfCurrentWeek(); }
        }
    }
}
