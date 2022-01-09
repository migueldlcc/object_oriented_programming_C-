using System;
using System.Collections.Generic;

namespace coms201_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> daysList = new List<string> {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
          
            Dictionary<int, string> daysDictionary = new Dictionary<int, string> {};
            daysDictionary.Add(0, "Monday");
            daysDictionary.Add(1, "Tuesday");
            daysDictionary.Add(2, "Wednesday");
            daysDictionary.Add(3, "Thursday");
            daysDictionary.Add(4, "Friday");
            daysDictionary.Add(5, "Saturday");
            daysDictionary.Add(6, "Sunday");

            Stack<string> daysStack = new Stack<string> {};
            daysStack.Push("Monday");
            daysStack.Push("Tuesday");
            daysStack.Push("Wednesday");
            daysStack.Push("Thursday");
            daysStack.Push("Friday");
            daysStack.Push("Saturday");
            daysStack.Push("Sunday");

            Queue<string> daysQueue = new Queue<string> {};
            daysQueue.Enqueue("Monday");
            daysQueue.Enqueue("Tuesday");
            daysQueue.Enqueue("Wednesday");
            daysQueue.Enqueue("Thursday");
            daysQueue.Enqueue("Friday");
            daysQueue.Enqueue("Saturday");
            daysQueue.Enqueue("Sunday");

            foreach (var day in daysList)
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine();
        }   
    }
}
