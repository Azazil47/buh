using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Assistant
    {
        public Assistant(System.Windows.Forms.ComboBox comboBox, List<String> list)
        {
            foreach (var item in DbManager.selectCatIncome())
            {
                comboBox.Items.Add(item);
            }
            comboBox.Items.Add("<добавить>");
        }
    }
}
