using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuDisplay : MenuItem
    {
        private IMenuDisplay m_Dispaly;

        public MenuDisplay() 
        {
            m_Dispaly = null;
        }

        public MenuDisplay(string i_OperationName, IMenuDisplay i_Display)
        {
            ItemName = i_OperationName;
            m_Dispaly = i_Display;
        }

        public override void Show()
        {
            m_Dispaly.Display();
        }
    }
}

