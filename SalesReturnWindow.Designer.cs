namespace Inventory_Management_System
{
    partial class SalesReturnWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.saleIDtxt = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRiceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProDisGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProTotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotDisGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totAmtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmtReceivedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmtReturnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payMethodGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.payTypeTxt = new System.Windows.Forms.TextBox();
            this.AmtreturnTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.barcoDetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(895, 53);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(138, 23);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.barcoDetxt);
            this.leftpanel.Controls.Add(this.label9);
            this.leftpanel.Controls.Add(this.AmtreturnTxt);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Controls.Add(this.payTypeTxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.dateTimePicker1);
            this.leftpanel.Controls.Add(this.userTxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.loadBtn);
            this.leftpanel.Controls.Add(this.saleIDtxt);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Size = new System.Drawing.Size(250, 569);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.saleIDtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.loadBtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.payTypeTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.AmtreturnTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label9, 0);
            this.leftpanel.Controls.SetChildIndex(this.barcoDetxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Size = new System.Drawing.Size(895, 569);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Sale ID";
            // 
            // saleIDtxt
            // 
            this.saleIDtxt.Location = new System.Drawing.Point(7, 92);
            this.saleIDtxt.Name = "saleIDtxt";
            this.saleIDtxt.Size = new System.Drawing.Size(237, 23);
            this.saleIDtxt.TabIndex = 3;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(7, 121);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(237, 34);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "&LOAD";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
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
            this.salesIdGV,
            this.proIdGV,
            this.BarcodeGV,
            this.productGV,
            this.pRiceGV,
            this.quanGV,
            this.perProDisGV,
            this.perProTotGV,
            this.TotDisGV,
            this.totAmtGV,
            this.AmtReceivedGV,
            this.AmtReturnGV,
            this.dateGV,
            this.payMethodGV,
            this.usrGV});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 479);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // salesIdGV
            // 
            this.salesIdGV.HeaderText = "Sale ID";
            this.salesIdGV.Name = "salesIdGV";
            this.salesIdGV.ReadOnly = true;
            this.salesIdGV.Visible = false;
            // 
            // proIdGV
            // 
            this.proIdGV.HeaderText = "Pro ID";
            this.proIdGV.Name = "proIdGV";
            this.proIdGV.ReadOnly = true;
            this.proIdGV.Visible = false;
            // 
            // BarcodeGV
            // 
            this.BarcodeGV.HeaderText = "Barcode";
            this.BarcodeGV.Name = "BarcodeGV";
            this.BarcodeGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // pRiceGV
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.pRiceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.pRiceGV.HeaderText = "Product Price";
            this.pRiceGV.Name = "pRiceGV";
            this.pRiceGV.ReadOnly = true;
            // 
            // quanGV
            // 
            this.quanGV.HeaderText = "Quantity";
            this.quanGV.Name = "quanGV";
            this.quanGV.ReadOnly = true;
            // 
            // perProDisGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.perProDisGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.perProDisGV.HeaderText = "Per Product Discount";
            this.perProDisGV.Name = "perProDisGV";
            this.perProDisGV.ReadOnly = true;
            this.perProDisGV.Visible = false;
            // 
            // perProTotGV
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.perProTotGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perProTotGV.HeaderText = "Per Product Total";
            this.perProTotGV.Name = "perProTotGV";
            this.perProTotGV.ReadOnly = true;
            this.perProTotGV.Visible = false;
            // 
            // TotDisGV
            // 
            this.TotDisGV.HeaderText = "Total Discount";
            this.TotDisGV.Name = "TotDisGV";
            this.TotDisGV.ReadOnly = true;
            this.TotDisGV.Visible = false;
            // 
            // totAmtGV
            // 
            this.totAmtGV.HeaderText = "Gross Total";
            this.totAmtGV.Name = "totAmtGV";
            this.totAmtGV.ReadOnly = true;
            // 
            // AmtReceivedGV
            // 
            this.AmtReceivedGV.HeaderText = "Amount Received";
            this.AmtReceivedGV.Name = "AmtReceivedGV";
            this.AmtReceivedGV.ReadOnly = true;
            this.AmtReceivedGV.Visible = false;
            // 
            // AmtReturnGV
            // 
            this.AmtReturnGV.HeaderText = "Cash Back";
            this.AmtReturnGV.Name = "AmtReturnGV";
            this.AmtReturnGV.ReadOnly = true;
            this.AmtReturnGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            this.dateGV.Visible = false;
            // 
            // payMethodGV
            // 
            this.payMethodGV.HeaderText = "Payment";
            this.payMethodGV.Name = "payMethodGV";
            this.payMethodGV.ReadOnly = true;
            this.payMethodGV.Visible = false;
            // 
            // usrGV
            // 
            this.usrGV.HeaderText = "User";
            this.usrGV.Name = "usrGV";
            this.usrGV.ReadOnly = true;
            this.usrGV.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // userTxt
            // 
            this.userTxt.Enabled = false;
            this.userTxt.Location = new System.Drawing.Point(7, 220);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(234, 23);
            this.userTxt.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyy hh:mm:ss tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pay Type";
            // 
            // payTypeTxt
            // 
            this.payTypeTxt.Enabled = false;
            this.payTypeTxt.Location = new System.Drawing.Point(7, 264);
            this.payTypeTxt.Name = "payTypeTxt";
            this.payTypeTxt.Size = new System.Drawing.Size(234, 23);
            this.payTypeTxt.TabIndex = 11;
            // 
            // AmtreturnTxt
            // 
            this.AmtreturnTxt.Enabled = false;
            this.AmtreturnTxt.Location = new System.Drawing.Point(7, 354);
            this.AmtreturnTxt.Name = "AmtreturnTxt";
            this.AmtreturnTxt.Size = new System.Drawing.Size(234, 23);
            this.AmtreturnTxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cash to Refund";
            // 
            // barcoDetxt
            // 
            this.barcoDetxt.Location = new System.Drawing.Point(7, 310);
            this.barcoDetxt.Name = "barcoDetxt";
            this.barcoDetxt.Size = new System.Drawing.Size(234, 23);
            this.barcoDetxt.TabIndex = 17;
            this.barcoDetxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcoDetxt_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Enter Barcode";
            // 
            // SalesReturnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Name = "SalesReturnWindow";
            this.Text = "Sales Return Window";
            this.Load += new System.EventHandler(this.SalesReturnWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox saleIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox payTypeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmtreturnTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barcoDetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRiceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProDisGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProTotGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotDisGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmtGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmtReceivedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmtReturnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn payMethodGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrGV;
    }
}