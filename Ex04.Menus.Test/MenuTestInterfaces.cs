using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuTestInterfaces
    {
        private MainMenu m_MainMenu;  

        public void MenuTestInterfacesRun()
        {
            m_MainMenu = new MainMenu("Interfaces Menu");
            MenuOperations DateOrTimeMenu = new MenuOperations("Show Date/Time");
            DateOrTimeMenu.AddItemToList(new MenuDisplay("Show Date", new Date()));
            DateOrTimeMenu.AddItemToList(new MenuDisplay("Show Time", new Time()));
            m_MainMenu.AppendNewItem(DateOrTimeMenu);
            MenuOperations VersionOrCapitalsMenu = new MenuOperations("Version and Capitals");
            VersionOrCapitalsMenu.AddItemToList(new MenuDisplay("Count Capitals", new Capitals()));
            VersionOrCapitalsMenu.AddItemToList(new MenuDisplay("Show Version", new Version()));
            m_MainMenu.AppendNewItem(VersionOrCapitalsMenu);

            m_MainMenu.Show();
        }
    }
}
