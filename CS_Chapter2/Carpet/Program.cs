using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 8;
            int width = 6;
            double price = (length * width);

            Console.WriteLine("The cost of the carpet per square foot is $" + price);
        }
    }
}
