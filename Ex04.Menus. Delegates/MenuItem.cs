using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuMethodAction();
    public class MenuItem
    {
        private string m_MenuTitle;
        public event MenuMethodAction MenuAction;
        private readonly List<MenuItem> r_SubMenuItems;

        public MenuItem(string i_MenuTitle, MenuMethodAction i_MenuAction, List<MenuItem> i_SubMenuItems = null)
        {
            this.m_MenuTitle = i_MenuTitle;
            this.MenuAction = i_MenuAction;
            this.r_SubMenuItems = i_SubMenuItems ?? new List<MenuItem>();
        }

        public string Title
        {
            get { return this.m_MenuTitle; }
        }

        public void AddSubMenuItem(MenuItem i_MenuItems)
        {
            this.r_SubMenuItems.Add(i_MenuItems);
        }

        public void ExecuteMenuItem()
        {
            Console.Clear();
            MenuAction.Invoke();
        }

        public void Show()
        {
            do
            {
                StringBuilder sb = new StringBuilder();
                string userInput = "";
                sb.AppendLine($"* {this.m_MenuTitle} *");
                sb.AppendLine("----------------------------");

                for (int i = 0; i < r_SubMenuItems.Count; i++)
                {
                    sb.AppendLine($"{i + 1} -> {r_SubMenuItems[i].Title}");
                }
                sb.AppendLine($"0 -> Back");
                sb.AppendLine("----------------------------");
                sb.AppendLine($"Enter your request: (1 to {r_SubMenuItems.Count} or press '0' to Back)");
                Console.WriteLine(sb);

                userInput = Console.ReadLine();
                while (inputValidationOptions(userInput, r_SubMenuItems.Count) != true)
                {
                    Console.WriteLine("Invalid choose");
                    userInput = Console.ReadLine();
                }
                if (userInput == "0")
                {
                    break;
                }
                if (r_SubMenuItems != null)
                {
                    r_SubMenuItems[int.Parse(userInput) - 1].ExecuteMenuItem();
                }
                else
                {
                    r_SubMenuItems[int.Parse(userInput) - 1].Show();
                }
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