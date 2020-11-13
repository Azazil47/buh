using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Assistant
    {
        public Assistant(System.Windows.Forms.ComboBox comboBox, string table)
        {
            foreach (var item in DbManager.selectAllfromTable(table))
            {
                comboBox.Items.Add(item);
            }
            comboBox.Items.Add("<добавить>");
        }
    }
}
