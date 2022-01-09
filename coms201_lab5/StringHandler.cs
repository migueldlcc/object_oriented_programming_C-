using System;
using System.Collections.Generic;
using System.Text;


namespace coms201_lab5
{
    struct StringHandler
    {
        public void Abbreviate(ref string month)
        {
            switch (month.ToUpper())
            {
                case "JANUARY":
                    Console.WriteLine("JAN");
                    break;
                case "FEBRUARY":
                    Console.WriteLine("FEB");
                    break;
                case "MARCH":
                    Console.WriteLine("MAR");
                    break;
                case "APRIL":
                    Console.WriteLine("APR");
                    break;
                case "MAY":
                    Console.WriteLine("MAY");
                    break;
                case "JUNE":
                    Console.WriteLine("JUN");
                    break;
                case "JULY":
                    Console.WriteLine("JUL");
                    break;
                case "AUGUST":
                    Console.WriteLine("AUG");
                    break;
                case "SEPTEMBER":
                    Console.WriteLine("SEP");
                    break;
                case "OCTOBER":
                    Console.WriteLine("OCT");
                    break;
                case "NOVEMBER":
                    Console.WriteLine("NOV");
                    break;
                case "DECEMBER":
                    Console.WriteLine("DEC");
                    break;
            }
        }
    }
}
