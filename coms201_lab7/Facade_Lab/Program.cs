using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Facade_Lab
{
    class Program
    {
        DateTime start = DateFacade.StartOfWeek;
        DateTime end = DateFacade.EndOfWeek; 
        void Main()
        {
            Console.WriteLine($"{start: Sunday, October 25, 2020 12:00 AM}");
            Console.WriteLine($"{end: Saturday, October 31, 2020 23:59:59 GMT}");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
