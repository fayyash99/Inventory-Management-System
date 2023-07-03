namespace Inventory_Management_System
{
    partial class categories
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
            this.label4 = new System.Windows.Forms.Label();
            this.activeErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.activeDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.activeDD);
            this.leftpanel.Controls.Add(this.categorytxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.activeErrorLabel);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.categoryErrorLabel);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.activeErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.categorytxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.activeDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Is Active";
            // 
            // activeErrorLabel
            // 
            this.activeErrorLabel.AutoSize = true;
            this.activeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.activeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.activeErrorLabel.Location = new System.Drawing.Point(224, 123);
            this.activeErrorLabel.Name = "activeErrorLabel";
            this.activeErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.activeErrorLabel.TabIndex = 23;
            this.activeErrorLabel.Text = "*";
            this.activeErrorLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category Name";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrorLabel.Location = new System.Drawing.Point(224, 78);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.categoryErrorLabel.TabIndex = 20;
            this.categoryErrorLabel.Text = "*";
            this.categoryErrorLabel.Visible = false;
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(6, 100);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(238, 23);
            this.categorytxt.TabIndex = 24;
            // 
            // activeDD
            // 
            this.activeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeDD.FormattingEnabled = true;
            this.activeDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activeDD.Location = new System.Drawing.Point(6, 145);
            this.activeDD.Name = "activeDD";
            this.activeDD.Size = new System.Drawing.Size(238, 23);
            this.activeDD.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.NameGV,
            this.StatusGV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 429);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catD";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label activeErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.ComboBox activeDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}