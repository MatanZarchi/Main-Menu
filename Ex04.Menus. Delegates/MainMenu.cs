using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private List<MenuItem> m_MenuItems;
        private string m_MenuTitle;

        public MainMenu(string i_MenuTitle)
        {
            this.m_MenuItems = new List<MenuItem>();
            this.m_MenuTitle = i_MenuTitle;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            this.m_MenuItems.Add(i_MenuItem);
        }

        public void Show()
        {
            do
            {
                StringBuilder sb = new StringBuilder();
                string userInput = "";
                sb.AppendLine($"* {this.m_MenuTitle} *");
                sb.AppendLine("----------------------------");

                for (int i = 0; i < m_MenuItems.Count; i++)
                {
                    sb.AppendLine($"{i + 1} -> {m_MenuItems[i].Title}");
                }
                sb.AppendLine($"0 -> Exit");
                sb.AppendLine("----------------------------");
                sb.AppendLine($"Enter your request: (1 to {m_MenuItems.Count} or press '0' to Exit)");
                Console.WriteLine(sb);

                userInput = Console.ReadLine();
                while (inputValidationOptions(userInput, m_MenuItems.Count) != true)
                {
                    Console.WriteLine("Invalid choose");
                    userInput = Console.ReadLine();
                }
                if (userInput == "0")
                {
                    break;
                }

                m_MenuItems[int.Parse(userInput) - 1].Show();
            } while (true);
        }

        private bool inputValidationOptions(string i_UserInput, int i_MenuSize)
        {
            bool inputValid = false;
            if (int.TryParse(i_UserInput, out int convertedNumber))
            {
                if (convertedNumber <= i_MenuSize)
                {
                    inputValid = true;
                }
            }
            return inputValid;
        }
    }
}