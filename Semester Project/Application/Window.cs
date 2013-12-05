/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Module: Window : Form
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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void open(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.open(new Sale());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.open(new Search());
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.open(new Inventory());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.open(new About());
        }
    }
}
