using System;

namespace COMS201_E52
{
    class Program
    {
        static void Main()
        {
            // To demonstrate dependency injection uncomment one of the following lines...
            // ILogger messageLogger = new TextLogger(@"C:\TEMP\MessageLog.TXT");  
            // ILogger messageLogger = new ExcelLogger(@"C:\TEMP\MessageLog.xlsx");


            // Start the domonstration here.
            ProgramLog programLog = new ProgramLog();
            
            string userResponse = "";
            while (userResponse != "quit")
            {
                Console.Write("Enter your message or \"quit\" to quit: ");
                userResponse = Console.ReadLine();

                // The following doesn not use dependency injection. 
                // It uses whatever logger (TXT or Excel) that the ProgramLog uses.
                programLog.Write(userResponse);

                // To demonstrate dependency injection uncomment the following line.
                // programLog.Write(userResponse, messageLogger);   
            }
        }
    }
}
