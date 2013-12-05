namespace PoS_new
{
    partial class Inventory
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
            this.tcInventory = new System.Windows.Forms.TabControl();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.lblAddProductWarning = new System.Windows.Forms.Label();
            this.btnAddProductSave = new System.Windows.Forms.Button();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.txtAddProductDesc = new System.Windows.Forms.TextBox();
            this.txtAddProductPrice = new System.Windows.Forms.TextBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddProductPrice = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.txtAddProductStock = new System.Windows.Forms.TextBox();
            this.lblAddProductStock = new System.Windows.Forms.Label();
            this.tcInventory.SuspendLayout();
            this.tpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tpAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInventory
            // 
            this.tcInventory.Controls.Add(this.tpInventory);
            this.tcInventory.Controls.Add(this.tpAddProduct);
            this.tcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInventory.Location = new System.Drawing.Point(0, 0);
            this.tcInventory.Name = "tcInventory";
            this.tcInventory.SelectedIndex = 0;
            this.tcInventory.Size = new System.Drawing.Size(624, 345);
            this.tcInventory.TabIndex = 0;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.dgvInventory);
            this.tpInventory.Location = new System.Drawing.Point(4, 22);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(616, 319);
            this.tpInventory.TabIndex = 2;
            this.tpInventory.Text = "Inventory";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.Color.Black;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(3, 3);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(610, 313);
            this.dgvInventory.TabIndex = 0;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.Controls.Add(this.lblAddProductWarning);
            this.tpAddProduct.Controls.Add(this.btnAddProductSave);
            this.tpAddProduct.Controls.Add(this.lblProductDescription);
            this.tpAddProduct.Controls.Add(this.txtAddProductDesc);
            this.tpAddProduct.Controls.Add(this.txtAddProductStock);
            this.tpAddProduct.Controls.Add(this.lblAddProductStock);
            this.tpAddProduct.Controls.Add(this.txtAddProductPrice);
            this.tpAddProduct.Controls.Add(this.txtAddProductName);
            this.tpAddProduct.Controls.Add(this.lblAddProductPrice);
            this.tpAddProduct.Controls.Add(this.lblAddProductName);
            this.tpAddProduct.Location = new System.Drawing.Point(4, 22);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProduct.Size = new System.Drawing.Size(616, 319);
            this.tpAddProduct.TabIndex = 0;
            this.tpAddProduct.Text = "Add Product";
            this.tpAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblAddProductWarning
            // 
            this.lblAddProductWarning.AutoSize = true;
            this.lblAddProductWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProductWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAddProductWarning.Location = new System.Drawing.Point(101, 227);
            this.lblAddProductWarning.Name = "lblAddProductWarning";
            this.lblAddProductWarning.Size = new System.Drawing.Size(33, 20);
            this.lblAddProductWarning.TabIndex = 9;
            this.lblAddProductWarning.Text = "null";
            this.lblAddProductWarning.Visible = false;
            // 
            // btnAddProductSave
            // 
            this.btnAddProductSave.Location = new System.Drawing.Point(496, 188);
            this.btnAddProductSave.Name = "btnAddProductSave";
            this.btnAddProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductSave.TabIndex = 8;
            this.btnAddProductSave.Text = "Add Product";
            this.btnAddProductSave.UseVisualStyleBackColor = true;
            this.btnAddProductSave.Click += new System.EventHandler(this.btnAddProductSave_Click);
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(24, 106);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(60, 13);
            this.lblProductDescription.TabIndex = 7;
            this.lblProductDescription.Text = "Description";
            // 
            // txtAddProductDesc
            // 
            this.txtAddProductDesc.Location = new System.Drawing.Point(105, 103);
            this.txtAddProductDesc.Multiline = true;
            this.txtAddProductDesc.Name = "txtAddProductDesc";
            this.txtAddProductDesc.Size = new System.Drawing.Size(466, 79);
            this.txtAddProductDesc.TabIndex = 6;
            // 
            // txtAddProductPrice
            // 
            this.txtAddProductPrice.Location = new System.Drawing.Point(105, 50);
            this.txtAddProductPrice.Name = "txtAddProductPrice";
            this.txtAddProductPrice.Size = new System.Drawing.Size(67, 20);
            this.txtAddProductPrice.TabIndex = 3;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Location = new System.Drawing.Point(105, 24);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(466, 20);
            this.txtAddProductName.TabIndex = 2;
            // 
            // lblAddProductPrice
            // 
            this.lblAddProductPrice.AutoSize = true;
            this.lblAddProductPrice.Location = new System.Drawing.Point(24, 53);
            this.lblAddProductPrice.Name = "lblAddProductPrice";
            this.lblAddProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblAddProductPrice.TabIndex = 1;
            this.lblAddProductPrice.Text = "Product Price";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(24, 27);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(75, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // txtAddProductStock
            // 
            this.txtAddProductStock.Enabled = false;
            this.txtAddProductStock.Location = new System.Drawing.Point(105, 76);
            this.txtAddProductStock.Name = "txtAddProductStock";
            this.txtAddProductStock.Size = new System.Drawing.Size(67, 20);
            this.txtAddProductStock.TabIndex = 5;
            // 
            // lblAddProductStock
            // 
            this.lblAddProductStock.AutoSize = true;
            this.lblAddProductStock.Enabled = false;
            this.lblAddProductStock.Location = new System.Drawing.Point(24, 79);
            this.lblAddProductStock.Name = "lblAddProductStock";
            this.lblAddProductStock.Size = new System.Drawing.Size(35, 13);
            this.lblAddProductStock.TabIndex = 4;
            this.lblAddProductStock.Text = "Stock";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 345);
            this.Controls.Add(this.tcInventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.tcInventory.ResumeLayout(false);
            this.tpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcInventory;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.TextBox txtAddProductPrice;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label lblAddProductPrice;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Button btnAddProductSave;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox txtAddProductDesc;
        private System.Windows.Forms.Label lblAddProductWarning;
        private System.Windows.Forms.TextBox txtAddProductStock;
        private System.Windows.Forms.Label lblAddProductStock;
    }
}