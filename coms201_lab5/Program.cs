﻿using System;

namespace coms201_lab5
{
    class Program  
    {
        static void Main(string[] args)
        {
            
            string userResponse = Console.ReadLine();
            while (userResponse.ToLower() != "quit")
            {
                Console.Write("Enter a month or 'QUIT' to quit: ");
                StringHandler abb = new StringHandler();
                Console.WriteLine(abb.Abbreviate(ref userResponse));
            }
        }

       
    }
}
