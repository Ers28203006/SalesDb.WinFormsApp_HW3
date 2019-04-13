using SalesDb.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDb.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customers(Покупатели)")
            {
                listBox1.Items.Clear();
                CustomerTableQuery.Show(listBox1);

            }
            else if(comboBox1.Text == "Sellers(Продавцы)")
            {
                listBox1.Items.Clear();
                SellersTableQuery.Show(listBox1);
            }
            else
            {
                listBox1.Items.Clear();
                SalesTableQuery.Show(listBox1);
            }
        }
    }
}
