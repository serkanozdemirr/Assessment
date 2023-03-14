namespace AssessmentWinForm
{
    partial class FormNorthWind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnCatagories = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnShippers = new System.Windows.Forms.Button();
            this.btnEmployess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(845, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // bttnCatagories
            // 
            this.bttnCatagories.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttnCatagories.Location = new System.Drawing.Point(12, 12);
            this.bttnCatagories.Name = "bttnCatagories";
            this.bttnCatagories.Size = new System.Drawing.Size(88, 49);
            this.bttnCatagories.TabIndex = 1;
            this.bttnCatagories.Text = "Categories";
            this.bttnCatagories.UseVisualStyleBackColor = false;
            this.bttnCatagories.Click += new System.EventHandler(this.bttnCatagories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProducts.Location = new System.Drawing.Point(132, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(88, 49);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrders.Location = new System.Drawing.Point(252, 12);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(88, 49);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.Location = new System.Drawing.Point(382, 12);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(88, 49);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSuppliers.Location = new System.Drawing.Point(502, 12);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(88, 49);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnShippers
            // 
            this.btnShippers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnShippers.Location = new System.Drawing.Point(621, 12);
            this.btnShippers.Name = "btnShippers";
            this.btnShippers.Size = new System.Drawing.Size(88, 49);
            this.btnShippers.TabIndex = 6;
            this.btnShippers.Text = "Shippers";
            this.btnShippers.UseVisualStyleBackColor = false;
            this.btnShippers.Click += new System.EventHandler(this.btnShippers_Click);
            // 
            // btnEmployess
            // 
            this.btnEmployess.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployess.Location = new System.Drawing.Point(742, 12);
            this.btnEmployess.Name = "btnEmployess";
            this.btnEmployess.Size = new System.Drawing.Size(88, 49);
            this.btnEmployess.TabIndex = 7;
            this.btnEmployess.Text = "Employees";
            this.btnEmployess.UseVisualStyleBackColor = false;
            this.btnEmployess.Click += new System.EventHandler(this.btnEmployess_Click);
            // 
            // FormNorthWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 522);
            this.Controls.Add(this.btnEmployess);
            this.Controls.Add(this.btnShippers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.bttnCatagories);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNorthWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "North Wind";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button bttnCatagories;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnCustomers;
        private Button btnSuppliers;
        private Button btnShippers;
        private Button btnEmployess;
    }
}