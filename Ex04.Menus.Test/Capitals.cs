using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Capitals:  IMenuDisplay
    {
        private short countUpperCase()
        {
            short upperCaseCounter = 0;

            Console.WriteLine("Please enter a sentence to search for capitals:");
            string userInputSentence = Console.ReadLine();

            foreach (char letter in userInputSentence)
            {
                if (char.IsUpper(letter))
                {
                    upperCaseCounter++;
                }
            }

            return upperCaseCounter;
        }

        public void Display()
        {
            short numOfUpperCase = this.countUpperCase();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{1}Number of upper - cases is: {0}{1}", numOfUpperCase, Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
