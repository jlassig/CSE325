using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task 2:
            string name = "Julia";
            string location = "Utah";

            // task 3:
            WriteLine($"My name is {name}.");
            WriteLine($"I am from {location}.");

            // task 4:
            DateTime today = DateTime.Now;

            //WriteLine($"Today's date: {today.ToString("MM/dd/yyyy")}");
            WriteLine($"Today's date: {today.ToString("d")}");


            // task 5:
            DateTime christmas = new DateTime(2023, 12, 25, 0, 0, 0);
            int daysLeft = (christmas - today).Days;
            WriteLine($"Days left till Christmas 2023: {daysLeft}");

            // task 6 and 7:
            WriteLine("\n****Getting the calculations for the window****");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            WriteLine("Enter the width of the string: ");
            widthString = ReadLine();
            width = double.Parse(widthString);
            WriteLine("Enter the height of the string: ");
            heightString = ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            WriteLine("The length of the wood is " +
            woodLength + " feet");
            WriteLine("The area of the glass is " +
            glassArea + " square metres");


            WriteLine("\nPress any key to exit.");
            ReadKey();

           



        }
    }
}
