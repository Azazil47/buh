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
            Assistant assistant = new Assistant(comboBox1, "category_incoming", "name");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lbName.Visible = true;
            tbNote.Visible = true;
            lbSum.Visible = true;
            tbSum.Visible = true;
            lbDate.Visible = true;
            dtCalendar.Visible = true;
            btAdd.Visible = true;
            btCancel.Visible = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            //if (DbManager.getId("category_incoming", comboBox1.Text) != -1)
            //{
            //    string st = DbManager.getId("category_incoming", comboBox1.Text).ToString();
            //    MessageBox.Show(st);
            //}
            //else
            //{
            //    MessageBox.Show("Такой записи нет в БД");
            //}
            
            DbManager.addIncome("incoming", comboBox1.Text, 222/*, 100.2, dtCalendar.Value*/);
           
                
            
            //MessageBox.Show(DbManager.CheckForMatches(comboBox1.Text, "category_incoming", "name").ToString());
        }
    }
}
