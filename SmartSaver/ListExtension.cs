using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomExtensions
{
    public static class ListExtension
    {
        public static ComboBox ToComboBox<T> (this List<T> list)
        {
            ComboBox comboBox = new ComboBox();

            foreach (T item in list)
            {
                comboBox.Items.Add(item);
            }

            return comboBox;
        }
    }
}
