﻿using System;
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
            foreach (var item in DbManager.selectCatIncome())
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
