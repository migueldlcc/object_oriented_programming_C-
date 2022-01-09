using System;
using System.Collections.Generic;
using System.Text;

namespace coms201_lab4
{
    class WeekDays
    {

        private List<Days> daysList = new List<Days> { };
        
        private Dictionary<int, Days> daysDictionary = new Dictionary<int, Days> { };

        private Stack<Days> daysStack = new Stack<Days> { };

        private Queue<Days> daysQueue = new Queue<Days> { };

        public void AddListDays(Days days)
        {
            daysList.Add(days);
        }

        public void AddDictionaryDays(int key, Days days)
        {
            daysDictionary.Add(key, days);
        }

        public void AddStackDays(Days days)
        {
            daysStack.Push(days);
        }

        public void AddQueueDays(Days days)
        {
            daysQueue.Enqueue(days);
        }
    }
}
