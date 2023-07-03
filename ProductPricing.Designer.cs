namespace Inventory_Management_System
{
    partial class ProductPricing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPRGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPRGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(638, 53);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(96, 23);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.categoryDD);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Size = new System.Drawing.Size(638, 450);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // categoryDD
            // 
            this.categoryDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(6, 94);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(238, 23);
            this.categoryDD.TabIndex = 31;
            this.categoryDD.SelectedIndexChanged += new System.EventHandler(this.categoryDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectGV,
            this.proIDGV,
            this.proGV,
            this.buyingPRGV,
            this.ProfitMarginGV,
            this.discountGV,
            this.finalPRGV});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 360);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // selectGV
            // 
            this.selectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectGV.FalseValue = "0";
            this.selectGV.HeaderText = "";
            this.selectGV.Name = "selectGV";
            this.selectGV.TrueValue = "1";
            this.selectGV.Width = 5;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.MaxInputLength = 100;
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.Name = "proGV";
            // 
            // buyingPRGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.buyingPRGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.buyingPRGV.HeaderText = "Buying Price";
            this.buyingPRGV.Name = "buyingPRGV";
            // 
            // ProfitMarginGV
            // 
            this.ProfitMarginGV.HeaderText = "Profit Margin %";
            this.ProfitMarginGV.Name = "ProfitMarginGV";
            // 
            // discountGV
            // 
            this.discountGV.HeaderText = "Discount %";
            this.discountGV.Name = "discountGV";
            // 
            // finalPRGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.finalPRGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.finalPRGV.HeaderText = "Selling Price";
            this.finalPRGV.Name = "finalPRGV";
            this.finalPRGV.ReadOnly = true;
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Name = "ProductPricing";
            this.Text = "Product Pricing";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPRGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPRGV;
    }
}