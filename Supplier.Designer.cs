namespace Inventory_Management_System
{
    partial class Supplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.suppliercompanytxt = new System.Windows.Forms.TextBox();
            this.personnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone1txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone2txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ntntxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ntnErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.phone2ErrorLabel = new System.Windows.Forms.Label();
            this.phone1ErrorLabel = new System.Windows.Forms.Label();
            this.personnameErrorLabel = new System.Windows.Forms.Label();
            this.suppliercompanyErrorLabel = new System.Windows.Forms.Label();
            this.lblstatusDD = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(83, 23);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.statusDD);
            this.leftpanel.Controls.Add(this.lblstatusDD);
            this.leftpanel.Controls.Add(this.ntntxt);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Controls.Add(this.addresstxt);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.phone2txt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.phone1txt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.personnametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.suppliercompanytxt);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.ntnErrorLabel);
            this.leftpanel.Controls.Add(this.addressErrorLabel);
            this.leftpanel.Controls.Add(this.phone2ErrorLabel);
            this.leftpanel.Controls.Add(this.phone1ErrorLabel);
            this.leftpanel.Controls.Add(this.personnameErrorLabel);
            this.leftpanel.Controls.Add(this.suppliercompanyErrorLabel);
            this.leftpanel.Controls.Add(this.statusErrorLabel);
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.suppliercompanyErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.personnameErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.phone1ErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.phone2ErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.ntnErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.suppliercompanytxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.personnametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.phone1txt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.phone2txt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.addresstxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.ntntxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblstatusDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Size = new System.Drawing.Size(550, 450);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name/Company";
            // 
            // suppliercompanytxt
            // 
            this.suppliercompanytxt.Location = new System.Drawing.Point(4, 95);
            this.suppliercompanytxt.MaxLength = 100;
            this.suppliercompanytxt.Name = "suppliercompanytxt";
            this.suppliercompanytxt.Size = new System.Drawing.Size(240, 23);
            this.suppliercompanytxt.TabIndex = 3;
            // 
            // personnametxt
            // 
            this.personnametxt.Location = new System.Drawing.Point(4, 140);
            this.personnametxt.MaxLength = 50;
            this.personnametxt.Name = "personnametxt";
            this.personnametxt.Size = new System.Drawing.Size(240, 23);
            this.personnametxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Person";
            // 
            // phone1txt
            // 
            this.phone1txt.Location = new System.Drawing.Point(4, 185);
            this.phone1txt.MaxLength = 15;
            this.phone1txt.Name = "phone1txt";
            this.phone1txt.Size = new System.Drawing.Size(240, 23);
            this.phone1txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone 1";
            // 
            // phone2txt
            // 
            this.phone2txt.Location = new System.Drawing.Point(4, 230);
            this.phone2txt.MaxLength = 15;
            this.phone2txt.Name = "phone2txt";
            this.phone2txt.Size = new System.Drawing.Size(240, 23);
            this.phone2txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone 2";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(4, 275);
            this.addresstxt.MaxLength = 100;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(240, 23);
            this.addresstxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // ntntxt
            // 
            this.ntntxt.Location = new System.Drawing.Point(4, 320);
            this.ntntxt.MaxLength = 25;
            this.ntntxt.Name = "ntntxt";
            this.ntntxt.Size = new System.Drawing.Size(240, 23);
            this.ntntxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "NTN #";
            // 
            // ntnErrorLabel
            // 
            this.ntnErrorLabel.AutoSize = true;
            this.ntnErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ntnErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ntnErrorLabel.Location = new System.Drawing.Point(224, 297);
            this.ntnErrorLabel.Name = "ntnErrorLabel";
            this.ntnErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.ntnErrorLabel.TabIndex = 15;
            this.ntnErrorLabel.Text = "*";
            this.ntnErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.addressErrorLabel.Location = new System.Drawing.Point(224, 252);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.addressErrorLabel.TabIndex = 16;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            // 
            // phone2ErrorLabel
            // 
            this.phone2ErrorLabel.AutoSize = true;
            this.phone2ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phone2ErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phone2ErrorLabel.Location = new System.Drawing.Point(224, 208);
            this.phone2ErrorLabel.Name = "phone2ErrorLabel";
            this.phone2ErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.phone2ErrorLabel.TabIndex = 17;
            this.phone2ErrorLabel.Text = "*";
            this.phone2ErrorLabel.Visible = false;
            // 
            // phone1ErrorLabel
            // 
            this.phone1ErrorLabel.AutoSize = true;
            this.phone1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phone1ErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phone1ErrorLabel.Location = new System.Drawing.Point(224, 163);
            this.phone1ErrorLabel.Name = "phone1ErrorLabel";
            this.phone1ErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.phone1ErrorLabel.TabIndex = 18;
            this.phone1ErrorLabel.Text = "*";
            this.phone1ErrorLabel.Visible = false;
            // 
            // personnameErrorLabel
            // 
            this.personnameErrorLabel.AutoSize = true;
            this.personnameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.personnameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.personnameErrorLabel.Location = new System.Drawing.Point(224, 117);
            this.personnameErrorLabel.Name = "personnameErrorLabel";
            this.personnameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.personnameErrorLabel.TabIndex = 19;
            this.personnameErrorLabel.Text = "*";
            this.personnameErrorLabel.Visible = false;
            // 
            // suppliercompanyErrorLabel
            // 
            this.suppliercompanyErrorLabel.AutoSize = true;
            this.suppliercompanyErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.suppliercompanyErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.suppliercompanyErrorLabel.Location = new System.Drawing.Point(224, 72);
            this.suppliercompanyErrorLabel.Name = "suppliercompanyErrorLabel";
            this.suppliercompanyErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.suppliercompanyErrorLabel.TabIndex = 20;
            this.suppliercompanyErrorLabel.Text = "*";
            this.suppliercompanyErrorLabel.Visible = false;
            // 
            // lblstatusDD
            // 
            this.lblstatusDD.AutoSize = true;
            this.lblstatusDD.Location = new System.Drawing.Point(0, 346);
            this.lblstatusDD.Name = "lblstatusDD";
            this.lblstatusDD.Size = new System.Drawing.Size(39, 15);
            this.lblstatusDD.TabIndex = 21;
            this.lblstatusDD.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(4, 365);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(240, 23);
            this.statusDD.TabIndex = 22;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLabel.Location = new System.Drawing.Point(224, 342);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 23;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
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
            this.suppIDGV,
            this.companyGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
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
            this.dataGridView1.Size = new System.Drawing.Size(550, 360);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "SuppD";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone2txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone1txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox suppliercompanytxt;
        private System.Windows.Forms.TextBox ntntxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ntnErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label phone2ErrorLabel;
        private System.Windows.Forms.Label phone1ErrorLabel;
        private System.Windows.Forms.Label personnameErrorLabel;
        private System.Windows.Forms.Label suppliercompanyErrorLabel;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label lblstatusDD;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}