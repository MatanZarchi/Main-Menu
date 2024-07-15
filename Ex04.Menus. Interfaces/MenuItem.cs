using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_ItemName;
        private int m_ItemNumber = 0;

        public int ItemNumber
        {
            get { return m_ItemNumber; }
            set { m_ItemNumber = value; }
        }

        public string ItemName
        {
            get { return m_ItemName; }
            set { m_ItemName = value; }
        }

        public abstract void Show();
    }
}
