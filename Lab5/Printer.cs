using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Printer
    {
        public void Print(string value)
        {
            Random randomColor = new Random();
            Console.ForegroundColor = (System.ConsoleColor)randomColor.Next(0, 15);
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
