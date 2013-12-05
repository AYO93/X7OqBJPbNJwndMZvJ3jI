/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
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

namespace PointOfSale
{
    public partial class Inventory : Form
    {
        private Stock stock;
        
        public Inventory()
        {
            stock = Stock.Instance;

            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = stock.getProducts();
        }

        private void btnAddProductSave_Click(object sender, EventArgs e)
        {
            lblAddProductWarning.Visible = false;

            string[] row = new string[4];

            row[0] = "0000";
            row[1] = txtAddProductName.Text.Trim();
            row[2] = txtAddProductPrice.Text.Trim();
            row[3] = txtAddProductDesc.Text.Trim();

            foreach(string col in row)
            {
                // Check for illegal characters and empty fields
                if(col.Trim() == "" || col.Contains(";"))
                {
                    // Show warning on illegal characters
                    lblAddProductWarning.Text = "Empty fields or illegal characters found!";
                    lblAddProductWarning.Visible = true;
                    return;
                }
            } // foreach

            // Add new product to inventory
            stock.addProduct(row);
            // Update DGV
            dgvInventory.DataSource = stock.getProducts();

            txtAddProductName.Clear();
            txtAddProductPrice.Clear();
            txtAddProductStock.Clear();
            txtAddProductDesc.Clear();

            this.tcInventory.SelectTab("tpInventory");
        }
    }
}
