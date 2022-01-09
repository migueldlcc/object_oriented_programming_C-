using System;

namespace COMS201_D6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() {
                ItemNumber = "PB-549",
                Description = "Piggy Bank",
                BasePrice = 11.95
            };

            Product product2 = new Product()
            {
                ItemNumber = "FB-108",
                Description = "Football",
                BasePrice = 22.00
            };

            PurchaseOrder myPO = new PurchaseOrder() { };
            LineItem item1 = new LineItem() { LineID = "001", Product = product1, Quantity = 1200, ShipDate = DateTime.Parse("2020-09-30") };
            LineItem item2 = new LineItem() { LineID = "002", Product = product1, Quantity = 600, ShipDate = DateTime.Parse("2020-10-31") };
            LineItem item3 = new LineItem() { LineID = "003", Product = product2, Quantity = 1200, ShipDate = DateTime.Parse("2020-09-30") };
            LineItem item4 = new LineItem() { LineID = "004", Product = product2, Quantity = 400, ShipDate = DateTime.Parse("2020-10-31") };

            // Add three LineItems and then remove one from myPO's ItemArray
            myPO.AddArrayItem(item1);
            myPO.AddArrayItem(item2);
            myPO.AddArrayItem(item3);
            myPO.AddArrayItem(item4);
            myPO.RemoveArrayItem(2);

            // Add three LineItems and then remove one from myPO's ItemList
            myPO.AddListItem(item1);
            myPO.AddListItem(item2);
            myPO.AddListItem(item3);
            myPO.AddListItem(item4);
            myPO.RemoveListItem(2);

            // Add three LineItems and then remove one from myPO's ItemDictionary
            myPO.AddDictionaryItem(item1.LineID, item1);
            myPO.AddDictionaryItem(item2.LineID, item2);
            myPO.AddDictionaryItem(item3.LineID, item3);
            myPO.AddDictionaryItem(item4.LineID, item4);
            myPO.RemoveDictionaryItem("003");

            // Add three LineItems and then remove one from myPO's ItemStack
            myPO.AddStackItem(item1);
            myPO.AddStackItem(item2);
            myPO.AddStackItem(item3);
            myPO.AddStackItem(item4);
            myPO.RemoveStackItem(2);

            // Add three LineItems and then remove one from myPO's ItemQueue
            myPO.AddQueueItem(item1);
            myPO.AddQueueItem(item2);
            myPO.AddQueueItem(item3);
            myPO.AddQueueItem(item4);
            myPO.RemoveQueueItem(2);

            Console.WriteLine("\nThis is the list of LineItems stored as an array:");
            foreach (LineItem lineItem in myPO.ArrayItem)
            {
                Console.WriteLine($"ID: { lineItem.LineID } Product: { lineItem.Product.ItemNumber } Price: {lineItem.Product.BasePrice:$0.00}");
            }
            Console.WriteLine($"After reading through the array ArrayItem.Length = { myPO.ArrayItem.Length }");

            Console.WriteLine("\nThis is the list of LineItems stored as a List:");
            foreach (LineItem lineItem in myPO.ListItem)
            {
                Console.WriteLine($"ID: { lineItem.LineID } Product: { lineItem.Product.ItemNumber } Price: {lineItem.Product.BasePrice:$0.00}");
            }
            Console.WriteLine($"After reading through the list ListItem.Count = { myPO.ListItem.Count }");

            Console.WriteLine("\nThis is the list of LineItems stored as a Dictionary:");
            foreach (LineItem lineItem in myPO.DictionaryItem.Values)
            {
                Console.WriteLine($"ID: { lineItem.LineID } Product: { lineItem.Product.ItemNumber } Price: {lineItem.Product.BasePrice:$0.00}");
            }
            Console.WriteLine($"After reading through the dictionary DictionaryItem.Count = { myPO.DictionaryItem.Count }");

            Console.WriteLine("\nThis is the list of LineItems stored as a Stack:");
            int stackCount = myPO.StackItem.Count;
            for (int i = 0; i < stackCount; i++)
            {
                LineItem lineItem = myPO.StackItem.Pop();
                Console.WriteLine($"ID: { lineItem.LineID } Product: { lineItem.Product.ItemNumber } Price: {lineItem.Product.BasePrice:$0.00}");
            }
            Console.WriteLine($"After reading through the stack StackItem.Count = { myPO.StackItem.Count }");

            Console.WriteLine("\nThis is the list of LineItems stored as a Queue:");
            int queueCount = myPO.QueueItem.Count;
            for (int i = 0; i < queueCount; i++)
            {
                LineItem lineItem = myPO.QueueItem.Dequeue();
                Console.WriteLine($"ID: { lineItem.LineID } Product: { lineItem.Product.ItemNumber } Price: {lineItem.Product.BasePrice:$0.00}");
            }
            Console.WriteLine($"After reading through the queue QueueItem.Count = { myPO.QueueItem.Count }");



            Console.WriteLine("\n\nPress Enter to quit...");
            Console.ReadLine();
        }
    }
}
