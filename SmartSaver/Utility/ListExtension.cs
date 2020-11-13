using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomExtensions
{
    public static class ListExtension
    {
        public static ComboBox ToComboBox<T>(this List<T> list, ComboBox comboBox)
        {

            foreach (T item in list)
            {
                comboBox.Items.Add(item);
            }

            return comboBox;
        }
    }
}
