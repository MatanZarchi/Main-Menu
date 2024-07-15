using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Version: IMenuDisplay
    {
        public void Display()
        {
            string version = "24.1.4.9633";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Version is: {0}{1}", version, Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
