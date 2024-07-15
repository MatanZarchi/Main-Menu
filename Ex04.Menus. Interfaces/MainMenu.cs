using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const int k_ExitItemPlace = 0;
        private const string k_ExitItemName = "Exit";
        private MenuOperations m_MenuList;

        public MainMenu(string i_MenuHeadLine)
        {
            m_MenuList = new MenuOperations(i_MenuHeadLine);
            m_MenuList.ItemsList[k_ExitItemPlace].ItemName = k_ExitItemName;
        }

        public void Show()
        {
            m_MenuList.Show();
        }

        public void AppendNewItem(MenuItem i_ItemToAdd)
        {
            m_MenuList.AddItemToList(i_ItemToAdd);
        }
    }
}
