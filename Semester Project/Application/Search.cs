/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Module: Search : Form
 * Date: 2013-12-05
 * Version: 1.0
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoS_new
{
    public partial class Search : Form
    {
        private BindingList<Product> Products;
        private Stock stock;

        public Search()
        {
            stock = Stock.Instance;
            Products = new BindingList<Product>();

            InitializeComponent();

            lbResults.DataSource = Products;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Clear the ProductSelector
            Products.Clear();

            if (txtSearch.Text.Trim() != "")
            {
                // Search for matching products and add them to ProductSelector
                foreach (Product product in stock.getStock())
                {
                    if (product.Contains(txtSearch.Text))
                        Products.Add(product);
                }
            }
        }
    }
}
