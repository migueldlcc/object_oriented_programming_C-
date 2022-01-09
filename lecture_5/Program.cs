using System;

namespace lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new MountainBike();

            b.Pedals = 2;
            b.Stop();
            Console.WriteLine("Press any key. ");
            Console.ReadKey();
        }
    }
}
