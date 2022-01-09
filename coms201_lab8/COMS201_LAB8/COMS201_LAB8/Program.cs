using System;

namespace COMS201_LAB8
{
    class Program
    {
        /* Put all of your code inside this Program class. */

        static int ConvertToInteger(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("The value entered is not in the correct format");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Value was either too large or too small for an Int32");
            }
            return 0;
        }
        
        static int ConvertToInteger(string number, ref string message)
        {
            try
            {
                return int.Parse(number);
            }
            catch (Exception e)
            {
                message = e.Message;
                message = $"Could not convert the string {number} to an integer";
                return 0;
            }
        }

        static int MonthNumber(string date)
        {
            return DateTime.Parse(date).Month;
        }


        /* Do not change any of the code in the Main() method. */
        static void Main()
        {
            var test = "***** IF YOU SEE THIS MESSAGE THEN YOUR ERROR HANDLER IS NOT WORKING PROPERLY *****";
            try
            {
                Console.WriteLine("\nTesting Part 1 FormatException...");
                Console.WriteLine(ConvertToInteger("A1"));

                Console.WriteLine("\nTesting Part 1 any other exception...");
                Console.WriteLine(ConvertToInteger("99999999999999999999"));

                Console.WriteLine("\nTesting part 2...");
                string m = "";
                int i = ConvertToInteger("A1", ref m);
                Console.WriteLine(m);
                Console.WriteLine(i);

                test = "This error is handled from the try..catch in the Main method.";
                Console.WriteLine("\nTesting part 3...");
                Console.WriteLine(MonthNumber("2/30/2020"));
            }
            catch (Exception e)
            {
                Console.WriteLine(test);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n\nPress Enter to quit...");
                Console.ReadLine();
            }
        }
    }
}
