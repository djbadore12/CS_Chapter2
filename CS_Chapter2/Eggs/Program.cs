using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenOne = 42;
            int chickenTwo = 34;
            int chickenThree = 56;
            int chickenFour = 64;

            int chickenOneDozens = chickenOne / 12;
            int chickenTwoDozens = chickenTwo / 12;
            int chickenThreeDozens = chickenThree / 12;
            int chickenFourDozens = chickenFour / 12;

            int remainderOne = chickenOneDozens % 12;
            int remainderTwo = chickenTwoDozens % 12;
            int remainderThree = chickenThreeDozens % 12;
            int remainderFour = chickenFourDozens % 12;

            Console.WriteLine("You will have " + chickenOneDozens + " dozens with " + remainderOne + " left over");
            Console.WriteLine("You will have " + chickenTwoDozens + " dozens with " + remainderTwo + " left over");
            Console.WriteLine("You will have " + chickenThreeDozens + " dozens with " + remainderThree + " left over");
            Console.WriteLine("You will have " + chickenFourDozens + " dozens with " + remainderFour + " left over");


        }
    }
}
