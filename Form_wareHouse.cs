using MyStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyStore
{
    public partial class Form_wareHouse : Form
    {
        private AppDataContext _context;
        public Form_wareHouse()
        {
            InitializeComponent();
            _context = new AppDataContext();
            var products = _context.Products; // Get the list of products
            foreach (var product in products)
            {
                // Display products in a ListBox or DataGridView
                listBoxProducts.Items.Add($"{product.Name} - ${product.Price}");
            }
        }

        private void Form_wareHouse_Load(object sender, EventArgs e)
        {

        }
    }
}
