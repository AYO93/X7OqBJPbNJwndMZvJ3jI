/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Date: 2013-12-04
 * Version: 1.0
 */
namespace PoS_new
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaleProduct = new System.Windows.Forms.Label();
            this.txtSaleProduct = new System.Windows.Forms.TextBox();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.lblSaleQty = new System.Windows.Forms.Label();
            this.lbSaleProduct = new System.Windows.Forms.ListBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnSaleAdd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaleProduct
            // 
            this.lblSaleProduct.AutoSize = true;
            this.lblSaleProduct.Location = new System.Drawing.Point(12, 16);
            this.lblSaleProduct.Name = "lblSaleProduct";
            this.lblSaleProduct.Size = new System.Drawing.Size(44, 13);
            this.lblSaleProduct.TabIndex = 103;
            this.lblSaleProduct.Text = "Product";
            // 
            // txtSaleProduct
            // 
            this.txtSaleProduct.Location = new System.Drawing.Point(64, 13);
            this.txtSaleProduct.Name = "txtSaleProduct";
            this.txtSaleProduct.Size = new System.Drawing.Size(502, 20);
            this.txtSaleProduct.TabIndex = 1;
            this.txtSaleProduct.TextChanged += new System.EventHandler(this.txtSaleProduct_TextChanged);
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.Location = new System.Drawing.Point(64, 150);
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.Size = new System.Drawing.Size(61, 20);
            this.txtSaleQty.TabIndex = 3;
            this.txtSaleQty.Text = "1";
            this.txtSaleQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaleQty
            // 
            this.lblSaleQty.AutoSize = true;
            this.lblSaleQty.Location = new System.Drawing.Point(12, 153);
            this.lblSaleQty.Name = "lblSaleQty";
            this.lblSaleQty.Size = new System.Drawing.Size(46, 13);
            this.lblSaleQty.TabIndex = 104;
            this.lblSaleQty.Text = "Quantity";
            // 
            // lbSaleProduct
            // 
            this.lbSaleProduct.FormattingEnabled = true;
            this.lbSaleProduct.Location = new System.Drawing.Point(64, 39);
            this.lbSaleProduct.Name = "lbSaleProduct";
            this.lbSaleProduct.Size = new System.Drawing.Size(502, 95);
            this.lbSaleProduct.TabIndex = 2;
            // 
            // dgvSale
            // 
            this.dgvSale.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSale.Location = new System.Drawing.Point(0, 184);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.Size = new System.Drawing.Size(734, 181);
            this.dgvSale.TabIndex = 4;
            this.dgvSale.TabStop = false;
            // 
            // btnSaleAdd
            // 
            this.btnSaleAdd.Location = new System.Drawing.Point(131, 140);
            this.btnSaleAdd.Name = "btnSaleAdd";
            this.btnSaleAdd.Size = new System.Drawing.Size(435, 38);
            this.btnSaleAdd.TabIndex = 4;
            this.btnSaleAdd.Text = "Add";
            this.btnSaleAdd.UseVisualStyleBackColor = true;
            this.btnSaleAdd.Click += new System.EventHandler(this.btnSaleAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotal.Location = new System.Drawing.Point(622, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(622, 39);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtPaid.TabIndex = 5;
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtChange.Location = new System.Drawing.Point(622, 65);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 7;
            this.txtChange.TabStop = false;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(572, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 100;
            this.lblTotal.Text = "Total";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(572, 42);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(28, 13);
            this.lblPaid.TabIndex = 101;
            this.lblPaid.Text = "Paid";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(572, 68);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(44, 13);
            this.lblChange.TabIndex = 102;
            this.lblChange.Text = "Change";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 365);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSaleAdd);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.lbSaleProduct);
            this.Controls.Add(this.lblSaleQty);
            this.Controls.Add(this.txtSaleQty);
            this.Controls.Add(this.txtSaleProduct);
            this.Controls.Add(this.lblSaleProduct);
            this.DoubleBuffered = true;
            this.Name = "Sale";
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleProduct;
        private System.Windows.Forms.TextBox txtSaleProduct;
        private System.Windows.Forms.TextBox txtSaleQty;
        private System.Windows.Forms.Label lblSaleQty;
        private System.Windows.Forms.ListBox lbSaleProduct;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnSaleAdd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblChange;

    }
}