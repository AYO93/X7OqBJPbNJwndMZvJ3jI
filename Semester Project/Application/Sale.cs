/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Module: Sale : Form
 * Date: 2013-12-05
 * Version: 1.1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Sale : Form
    {
        private Stock stock;
        private BindingList<Product> ProductSelector;
        private BindingList<Product> Cart;

        public Sale()
        {
            // Initialize Stock, ProductSelector and Cart
            stock = Stock.Instance;
            ProductSelector = stock.getProducts();
            Cart = new BindingList<Product>();

            InitializeComponent();

            // Set the lb's DataSource to the ProductSelector
            lbSaleProduct.DataSource = ProductSelector;
            dgvSale.DataSource = Cart;
        }

        private void txtSaleProduct_TextChanged(object sender, EventArgs e)
        {
            // Clear the ProductSelector
            ProductSelector.Clear();

            // Search for matching products and add them to ProductSelector
            foreach (Product product in stock.getProducts())
            {
                if (product.Contains(txtSaleProduct.Text))
                    ProductSelector.Add(product);
            }
        }

        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Int32.TryParse(txtSaleQty.Text.Trim(), out Quantity);

            decimal Total = 0;
            Product SelectedProduct = ProductSelector.ElementAt(lbSaleProduct.SelectedIndex);

            if (Cart.Contains(SelectedProduct))
            {
                Product product = Cart.ElementAt(Cart.IndexOf(SelectedProduct));
                Cart.Remove(SelectedProduct);

                product.Quantity += Quantity;
            }
            else
            {
                SelectedProduct.Quantity = Quantity;
            }

            SelectedProduct.Total = SelectedProduct.Price * SelectedProduct.Quantity;

            Cart.Add(SelectedProduct);

            foreach (Product product in Cart)
                Total += product.Total;

            txtTotal.Text = Total.ToString();
            txtSaleQty.Text = "1";
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            decimal Paid = 0;
            decimal Total = 0;

            Decimal.TryParse(txtTotal.Text, out Total);
            Decimal.TryParse(txtPaid.Text.Trim(), out Paid);

            if (Paid != 0)
                txtChange.Text = (Paid - Total).ToString();
            else
                txtChange.Text = "";
        }
    }
}
