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
        private string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget.mdb"; //Строка подключения
        private OleDbConnection dbConnection;
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        private double costs;
        public double Costs
        {
            get
            {
                return costs;
            }
            set
            {
                costs = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(connectionString);
            try
            {
                dbConnection.Open();
                lbConnect.Text = "Соединение с БД установлено";
            } catch
            {
                lbConnect.Text = "Соединение с БД не установлено";
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
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
