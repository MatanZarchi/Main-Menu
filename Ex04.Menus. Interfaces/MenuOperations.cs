using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuOperations: MenuItem
    {
        private const int k_UpperMenuPlace = 0;
        private const string k_UpperMenuName = "Back";
        private readonly List<MenuItem> r_ItemsList;

        private void byeMessage()
        { 
            for (int i = 0; i < 3; i++)  
            { Console.WriteLine(Environment.NewLine); }

            string draw = string.Format(
                @"

                 ********         *       *       ***********                  0         0
                 *       *        *       *       *                                 |
                 *        *       *       *       *                          *             *
                 ***********      *********       **********                  *           *   
                 *          *         *           *                            ***********
                 *         *          *           *
                 **********           *           ***********

");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(draw);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public List<MenuItem> ItemsList
        {
            get { return r_ItemsList; }
        }

        public MenuOperations(string i_ItemName)
        {
            ItemName = i_ItemName;
            r_ItemsList = new List<MenuItem>();
            MenuDisplay lastItem = new MenuDisplay();
            r_ItemsList.Add(lastItem);
            r_ItemsList[k_UpperMenuPlace].ItemName = k_UpperMenuName;
        }

        public void AddItemToList(MenuItem i_ItemToAdd)
        {
            i_ItemToAdd.ItemNumber = r_ItemsList.Count;
            r_ItemsList.Add(i_ItemToAdd);
        }       

        private void displayMenu()
        {
            int userChoice;

            do
            {
                Console.WriteLine(ItemName);
                foreach (char linesToPrint in ItemName)
                {
                    Console.Write("*");
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Please choose one of the following options. Press 0 to Exit or to go Back :{0}",Environment.NewLine);
                this.printMenuOptions();
                userChoice = this.checkUserChoose();
                Console.Clear();

                if (userChoice != k_UpperMenuPlace)
                {
                    r_ItemsList[userChoice].Show();
                }
            }
            while (userChoice != k_UpperMenuPlace);
        }

        private void printMenuOptions()
        {
            Console.WriteLine("--------------------------");

            foreach (MenuItem menuItem in r_ItemsList)
            {
                Console.WriteLine("{0} -> {1}", menuItem.ItemNumber, menuItem.ItemName);
            }

            Console.WriteLine("--------------------------");
        }

        private int checkUserChoose()
        {
            int userChoose;
            string ParseUserChooseToString = Console.ReadLine();

            while (!int.TryParse(ParseUserChooseToString, out userChoose) ||
                (userChoose < 0 || userChoose > r_ItemsList.Count - 1)) 
            {
                Console.WriteLine("Invalid Input.Please try again:");
                ParseUserChooseToString = Console.ReadLine();
            }

            return userChoose;
        }

        public override void Show()
        {
            if (r_ItemsList.Count == 0)
            {
                MenuDisplay lastItem = new MenuDisplay();
                r_ItemsList.Add(lastItem);
                r_ItemsList[k_UpperMenuPlace].ItemName = k_UpperMenuName;
            }

            this.displayMenu();
            if (ItemsList[0].ItemName == "Exit")
            {
                this.byeMessage();
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
