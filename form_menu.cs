using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void ขายสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_sell form_Sell = new Form_sell();
            form_Sell.TopLevel = false;
            form_Sell.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form_Sell);
            form_Sell.Show();

        }

        private void คลงสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_wareHouse form_wareHouse = new Form_wareHouse();
            form_wareHouse.TopLevel = false;
            form_wareHouse.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form_wareHouse);
            form_wareHouse.Show();

        }

        private void สรปยอดขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_SalesSummary form_SalesSummary = new Form_SalesSummary();
            form_SalesSummary.TopLevel = false;
            form_SalesSummary.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form_SalesSummary);
            form_SalesSummary.Show();
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
