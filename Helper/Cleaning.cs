using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Helper
{
    internal class Cleaning
    {
        public static void clearAll(Form form) 
        {
            foreach (var item in form.Controls)
            {
                if(item is TextBox)
                {
                    TextBox textBox= (TextBox)item;
                    textBox.Clear();
                }
            }
        }
    }
}
