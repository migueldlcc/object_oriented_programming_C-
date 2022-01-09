using System;
using System.Collections.Generic;
using System.Text;

namespace COMS201_E52
{
    class ProgramLog
    {
        // Doing things this way requires changing this ProgramLog class whenever we change
        // the way we want to log a message. If we change from a TXT file to an Excel file
        // we have to change this class. If we change from a Excel file to a database,
        // we would have to change this class again.
        public void Write(string message)
        {
            TextLogger logger = new TextLogger(@"C:\TEMP\MessageLog.TXT");
            //ExcelMessageLogger logger = new ExcelMessageLogger(@"C:\TEMP\MessageLog.xlsx");
            logger.Save(message);
        }


        // Using dependency injection we never have to change this class as long as the logger
        // object implements the ILogger interface.
        // This Write method uses dependency injection.
        public void Write(string message, ILogger logger)
        {
            logger.Save(message);
        }
    }
}
