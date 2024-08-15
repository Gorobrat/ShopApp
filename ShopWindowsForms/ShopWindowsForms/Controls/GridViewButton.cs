using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWindowsForms.Controls;

namespace ShopWindowsForms.Controls
{
    internal class GridViewButton
    {
        public DataGridViewButtonColumn AddButtonColumn(string name)
        {
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Action";
            btn1.Text = name;
            btn1.Name = "btn";
            btn1.UseColumnTextForButtonValue = true;

            return btn1;
        }
    }
}
