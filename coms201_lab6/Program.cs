using System;

namespace coms201_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("parameter count = {0}", args.Length);
            //for (int i = 0; i < args.Length; i++)
            //{
            //Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}
            //Array.Clear(args, 1, 1);
            //args[3] = "great";
            //for (int i = 0; i < args.Length; i++)
            //{
            //Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}


            //Console.ReadLine();

            string[,] seatingChart = new string[2, 2];
            seatingChart[0, 0] = "Mary";
            seatingChart[0, 1] = "Jim";
            seatingChart[1, 0] = "Bob";
            seatingChart[1, 1] = "Jane";

            for (int row = 0; row < 2; row++)
            {
                for (int seat = 0; seat < 2; seat++)
                {
                    Console.WriteLine("Row: {0} Seat: {1} Student: {2}",
                        (row + 1), (seat + 1), seatingChart[row, seat]);
                }
            }
        }
    }
}
