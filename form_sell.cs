using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class Form_sell : Form
    {
        private AppDataContext _context;
        public Form_sell()
        {
            InitializeComponent();
            _context = new AppDataContext();
        }

        private void form_sell_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newProduct = new Product { Id = 4, Name = "Product 4", Price = 40.00m };
            _context.AddProduct(newProduct);
        }
    }
}
