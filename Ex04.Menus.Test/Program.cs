using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
 
        static void Main()
        {
            MenuTestInterfaces menuInterfaces = new MenuTestInterfaces();
            menuInterfaces.MenuTestInterfacesRun();

            Ex04.Menus.Delegates.MainMenu mainMenu = new Ex04.Menus.Delegates.MainMenu("Delegates Main Menu");
            Ex04.Menus.Delegates.MenuItem dateMenuItem = new Ex04.Menus.Delegates.MenuItem("Show Date", new Date().Display);
            Ex04.Menus.Delegates.MenuItem timeMenuItem = new Ex04.Menus.Delegates.MenuItem("Show Time", new Time().Display);
            Ex04.Menus.Delegates.MenuItem dateTimeMenuItem = new Ex04.Menus.Delegates.MenuItem("Show Date/Time", null, new List<Ex04.Menus.Delegates.MenuItem> { dateMenuItem, timeMenuItem });

            Ex04.Menus.Delegates.MenuItem versionMenuItem = new Ex04.Menus.Delegates.MenuItem("Show Version", new Version().Display);
            Ex04.Menus.Delegates.MenuItem capitalMenuItem = new Ex04.Menus.Delegates.MenuItem("Count Capitals", new Capitals().Display);
            Ex04.Menus.Delegates.MenuItem versionCapitalMenuItem = new Ex04.Menus.Delegates.MenuItem("Version and Capitals", null, new List<Ex04.Menus.Delegates.MenuItem> { versionMenuItem, capitalMenuItem });

            mainMenu.AddMenuItem(dateTimeMenuItem);
            mainMenu.AddMenuItem(versionCapitalMenuItem);
            mainMenu.Show();
        }
    }
}
