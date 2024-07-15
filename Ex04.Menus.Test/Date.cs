using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Date: IMenuDisplay
    {
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current Date is: {0}{1}", DateTime.Now.ToShortDateString(), Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
