using System;

namespace COMS201_LAB_03
{
    class Textbook : Book
    {
        public double ListPrice { get; set; }

        public void Buy(Person person)
        {
            Console.WriteLine($"The cost of \"{Title}\" by \"{Author.Name}\" is {ListPrice}");
            Console.WriteLine("Would you like to buy this book? (Y/N): ");
            String Response = Console.ReadLine();
            if (Response == "Y" || Response == "y")
            {
                Console.WriteLine($"\"{person.Name}\" bought \"{Title}\" with Id: \"{Id}\" ");
            }

        }

        public void Sell(Double money)
        {
            money = 2 * ListPrice;
            Console.WriteLine($"The new list price of \"{Title}\" by \"{Author.Name}\" is \"{money}\" ");

        }
    }
}
