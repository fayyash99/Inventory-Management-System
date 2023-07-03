namespace Inventory_Management_System
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.productDD = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.suppBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.salereturnBtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.tableLayoutPanel1);
            this.rightpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productDD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsersBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.catBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.suppBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.salereturnBtn, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 482);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // salesBtn
            // 
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salesBtn.Image = global::Inventory_Management_System.Properties.Resources.Salesicon;
            this.salesBtn.Location = new System.Drawing.Point(547, 3);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(133, 90);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "Sales";
            this.salesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseBtn.FlatAppearance.BorderSize = 2;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purchaseBtn.Image = global::Inventory_Management_System.Properties.Resources.pur_invoiceicon;
            this.purchaseBtn.Location = new System.Drawing.Point(411, 3);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(130, 90);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase Invoice";
            this.purchaseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.purchaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.BorderSize = 2;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stockBtn.Image = global::Inventory_Management_System.Properties.Resources.Stockicon;
            this.stockBtn.Location = new System.Drawing.Point(275, 3);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(130, 90);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // productDD
            // 
            this.productDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productDD.FlatAppearance.BorderSize = 2;
            this.productDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productDD.Image = global::Inventory_Management_System.Properties.Resources.proicon;
            this.productDD.Location = new System.Drawing.Point(139, 3);
            this.productDD.Name = "productDD";
            this.productDD.Size = new System.Drawing.Size(130, 90);
            this.productDD.TabIndex = 1;
            this.productDD.Text = "Products";
            this.productDD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productDD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productDD.UseVisualStyleBackColor = true;
            this.productDD.Click += new System.EventHandler(this.productDD_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsersBtn.FlatAppearance.BorderSize = 2;
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsersBtn.Image = global::Inventory_Management_System.Properties.Resources.usericon;
            this.UsersBtn.Location = new System.Drawing.Point(3, 3);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(130, 90);
            this.UsersBtn.TabIndex = 0;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catBtn.FlatAppearance.BorderSize = 2;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catBtn.Image = global::Inventory_Management_System.Properties.Resources.Categoryicon;
            this.catBtn.Location = new System.Drawing.Point(3, 99);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(130, 90);
            this.catBtn.TabIndex = 5;
            this.catBtn.Text = "Categories";
            this.catBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.catBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // suppBtn
            // 
            this.suppBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suppBtn.FlatAppearance.BorderSize = 2;
            this.suppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.suppBtn.Image = global::Inventory_Management_System.Properties.Resources.Suppliericon;
            this.suppBtn.Location = new System.Drawing.Point(139, 99);
            this.suppBtn.Name = "suppBtn";
            this.suppBtn.Size = new System.Drawing.Size(130, 90);
            this.suppBtn.TabIndex = 6;
            this.suppBtn.Text = "Suppliers";
            this.suppBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.suppBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.suppBtn.UseVisualStyleBackColor = true;
            this.suppBtn.Click += new System.EventHandler(this.suppBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceBtn.FlatAppearance.BorderSize = 2;
            this.priceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceBtn.Image = global::Inventory_Management_System.Properties.Resources.productpriceicon;
            this.priceBtn.Location = new System.Drawing.Point(275, 99);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(130, 90);
            this.priceBtn.TabIndex = 7;
            this.priceBtn.Text = "Product Pricing";
            this.priceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.priceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.priceBtn.UseVisualStyleBackColor = true;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // salereturnBtn
            // 
            this.salereturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salereturnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salereturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salereturnBtn.FlatAppearance.BorderSize = 2;
            this.salereturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salereturnBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salereturnBtn.Image = global::Inventory_Management_System.Properties.Resources.return1;
            this.salereturnBtn.Location = new System.Drawing.Point(411, 99);
            this.salereturnBtn.Name = "salereturnBtn";
            this.salereturnBtn.Size = new System.Drawing.Size(130, 90);
            this.salereturnBtn.TabIndex = 8;
            this.salereturnBtn.Text = "Sales Return";
            this.salereturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salereturnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salereturnBtn.UseVisualStyleBackColor = true;
            this.salereturnBtn.Click += new System.EventHandler(this.salereturnBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productDD;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button suppBtn;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Button salereturnBtn;
    }
}