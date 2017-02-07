using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;

            int total = length + width;
            int squareFeet = total / 9;
        
            int cost = 14 * squareFeet;

            Console.WriteLine("It will cost you $" + cost + " to carpet the room");
            
        }
    }
}
