﻿using System;

namespace MyFirstConsoleApplication
{
    class GlazerApp
    {
        public static void RunExample()
        {
            Console.WriteLine("\nWelcome to teh Glazer App");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please Enter the Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please Enter the Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
}
