using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Assistant
    {
        public Assistant(System.Windows.Forms.ComboBox comboBox, string table)
        {
            foreach (object item in DbManager.selectAllfromTable(table))
            {
                OleDbDataReader read = (OleDbDataReader)item;
                comboBox.Items.Add(read["name"]);
            }
            comboBox.Items.Add("<добавить>");
        }
    }
}
