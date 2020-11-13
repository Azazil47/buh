using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class FormIncome : Form
    {
        public FormIncome()
        {
            InitializeComponent();
        }

        private void FormIncome_Load(object sender, EventArgs e)
        {
            Assistant assistant = new Assistant(comboBox1, DbManager.selectCatIncome());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lbName.Visible = true;
            tbName.Visible = true;
            lbDate.Visible = true;
            dtCalendar.Visible = true;
        }
    }
}
