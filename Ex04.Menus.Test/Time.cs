using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Time: IMenuDisplay
    {
        public void Display()
        {
            string time = DateTime.Now.ToString("hh:mm:ss tt");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The current time is {0}{1}", time, Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
