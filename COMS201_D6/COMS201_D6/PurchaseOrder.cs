using System;
using System.Collections.Generic;
using System.Text;

namespace COMS201_D6
{
    class PurchaseOrder
    {
        public LineItem[] ArrayItem = new LineItem[] { };

        public List<LineItem> ListItem = new List<LineItem> { };

        public Dictionary<string, LineItem> DictionaryItem = new Dictionary<string, LineItem> { };

        public Stack<LineItem> StackItem = new Stack<LineItem> { };

        public Queue<LineItem> QueueItem = new Queue<LineItem> { };

        // Adding an item to an array.
        public void AddArrayItem(LineItem item)
        {
            Array.Resize(ref ArrayItem, ArrayItem.Length + 1);
            ArrayItem[ArrayItem.GetUpperBound(0)] = item;
        }

        // Adding an item to a List.
        public void AddListItem(LineItem item)
        {
            ListItem.Add(item);
        }

        // Adding an item to a Dictionary.
        public void AddDictionaryItem(string key, LineItem item)
        {
            DictionaryItem.Add(key, item);
        }

        public void AddStackItem(LineItem item)
        {
            StackItem.Push(item);
        }

        public void AddQueueItem(LineItem item)
        {
            QueueItem.Enqueue(item);
        }
        
        public void RemoveArrayItem(int index)
        {
            // C# won't let you set the size of an array except with a constant or literal value.
            LineItem[] newArray = new LineItem[] { };
            // So we have to create the array and then use the Array.Resize() method to set its size.
            Array.Resize(ref newArray, ArrayItem.Length - 1);
            // Now copy the first part of the source array to the destination.
            Array.Copy(ArrayItem, 0, newArray, 0, index);
            // Skip the element we are removing and copy the second part of the source to the destination.
            Array.Copy(ArrayItem, index + 1, newArray, index, ArrayItem.GetUpperBound(0) - index);
            // Now that we've created a new array without the element we wated to remove, copy it to ArrayItem;
            Array.Resize(ref ArrayItem, ArrayItem.Length - 1);
            Array.Copy(newArray, ArrayItem, newArray.Length);
        }

        public void RemoveListItem(int index)
        {
            ListItem.Remove(ListItem[index]);
        }

        public void RemoveDictionaryItem(string key)
        {
            DictionaryItem.Remove(key);
        }
    
        public void RemoveStackItem(int index)
        {
            // We can only read/remove the top item from a stack.
            // So we have to remove each item and put it into a new stack.
            Stack<LineItem> newStack = new Stack<LineItem> { };
            // We can't simply write for (int i = 0; i < StackItem.Count; i++) because StackItem.Count
            // is going to change as the for..loop runs and an error would occur.
            int stackCount = StackItem.Count;
            for (int i = 0; i < stackCount; i++)
            {
                // The Pop() method returns the top item on the stack and removes it from the stack.
                LineItem topItem = StackItem.Pop();
                
                // Put topItem on newStack if it does not match the index being removed.
                if (i != index)
                {
                    newStack.Push(topItem);
                }
            }

            // Now we have our new stack, but the elements are in reverse order.
            // So we have to rebuild it to undo the reverse.
            stackCount = newStack.Count;
            for(int i = 0; i < stackCount; i++)
            {
                LineItem topItem = newStack.Pop();
                StackItem.Push(topItem);
            }
        }

        public void RemoveQueueItem(int index)
        {
            // We can only read/remove the bottom item from a queue.
            // So we have to remove each item and put it into a new queue.
            Queue<LineItem> newQueue = new Queue<LineItem> { };
            // We can't simply write for (int i = 0; i < QueueItem.Count; i++) because QueueItem.Count
            // is going to change as the for..loop runs and an error would occur.
            int queueCount = QueueItem.Count;
            for (int i = 0; i < queueCount; i++)
            {
                // The Dequeue() method returns the bottom item on the queue and removes it from the queue.
                LineItem bottomItem = QueueItem.Dequeue();

                // Put bottomItem on newQueue if it does not match the index being removed.
                if (i != index)
                {
                    newQueue.Enqueue(bottomItem);
                }
            }

            // Unlike stacks, queues are first-in-first-out, so newQueue is already in the correct order.
            // We just need to copy newQueue to QueueItem.
            QueueItem = newQueue;
        }
    }
}
