using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Form1 : Form
    {
        //private string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget.mdb"; //Строка подключения
        //public OleDbConnection dbConnection;
        
        public Form1()
        {
            InitializeComponent();
            if (DbManager.connectDb())
            {
                lbConnect.Text = "Соединение с БД установлено";
            } //Соединение с БД и вывод результата в lable
            else
            {
                lbConnect.Text = "Соединение с БД не установлено";
            }//В случае неудачного соединения

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbManager.connectDb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btIncome_Click(object sender, EventArgs e)
        {
            FormIncome formincome = new FormIncome();
            formincome.Show();
        }
    }
}
