namespace Inventory_Management_System
{
    partial class setting
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
            this.Serverlabel = new System.Windows.Forms.Label();
            this.Servertxt = new System.Windows.Forms.TextBox();
            this.DataBasetxt = new System.Windows.Forms.TextBox();
            this.Databaselabel = new System.Windows.Forms.Label();
            this.userIDtxt = new System.Windows.Forms.TextBox();
            this.useridlabel = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.IntegratedSecurityCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.saveBtn);
            this.leftpanel.Controls.Add(this.IntegratedSecurityCB);
            this.leftpanel.Controls.Add(this.passwordtxt);
            this.leftpanel.Controls.Add(this.passlabel);
            this.leftpanel.Controls.Add(this.userIDtxt);
            this.leftpanel.Controls.Add(this.useridlabel);
            this.leftpanel.Controls.Add(this.DataBasetxt);
            this.leftpanel.Controls.Add(this.Databaselabel);
            this.leftpanel.Controls.Add(this.Servertxt);
            this.leftpanel.Controls.Add(this.Serverlabel);
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.Serverlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.Servertxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.Databaselabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.DataBasetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.useridlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.userIDtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.IntegratedSecurityCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(550, 450);
            // 
            // Serverlabel
            // 
            this.Serverlabel.AutoSize = true;
            this.Serverlabel.Location = new System.Drawing.Point(3, 113);
            this.Serverlabel.Name = "Serverlabel";
            this.Serverlabel.Size = new System.Drawing.Size(39, 15);
            this.Serverlabel.TabIndex = 2;
            this.Serverlabel.Text = "Server";
            // 
            // Servertxt
            // 
            this.Servertxt.Location = new System.Drawing.Point(6, 131);
            this.Servertxt.MaxLength = 50;
            this.Servertxt.Name = "Servertxt";
            this.Servertxt.Size = new System.Drawing.Size(238, 23);
            this.Servertxt.TabIndex = 3;
            // 
            // DataBasetxt
            // 
            this.DataBasetxt.Location = new System.Drawing.Point(6, 175);
            this.DataBasetxt.MaxLength = 50;
            this.DataBasetxt.Name = "DataBasetxt";
            this.DataBasetxt.Size = new System.Drawing.Size(238, 23);
            this.DataBasetxt.TabIndex = 5;
            // 
            // Databaselabel
            // 
            this.Databaselabel.AutoSize = true;
            this.Databaselabel.Location = new System.Drawing.Point(3, 157);
            this.Databaselabel.Name = "Databaselabel";
            this.Databaselabel.Size = new System.Drawing.Size(55, 15);
            this.Databaselabel.TabIndex = 4;
            this.Databaselabel.Text = "DataBase";
            // 
            // userIDtxt
            // 
            this.userIDtxt.Location = new System.Drawing.Point(6, 219);
            this.userIDtxt.MaxLength = 50;
            this.userIDtxt.Name = "userIDtxt";
            this.userIDtxt.Size = new System.Drawing.Size(238, 23);
            this.userIDtxt.TabIndex = 7;
            // 
            // useridlabel
            // 
            this.useridlabel.AutoSize = true;
            this.useridlabel.Location = new System.Drawing.Point(3, 201);
            this.useridlabel.Name = "useridlabel";
            this.useridlabel.Size = new System.Drawing.Size(44, 15);
            this.useridlabel.TabIndex = 6;
            this.useridlabel.Text = "User ID";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(6, 263);
            this.passwordtxt.MaxLength = 50;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(238, 23);
            this.passwordtxt.TabIndex = 9;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(3, 245);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(57, 15);
            this.passlabel.TabIndex = 8;
            this.passlabel.Text = "Password";
            // 
            // IntegratedSecurityCB
            // 
            this.IntegratedSecurityCB.AutoSize = true;
            this.IntegratedSecurityCB.Location = new System.Drawing.Point(6, 292);
            this.IntegratedSecurityCB.Name = "IntegratedSecurityCB";
            this.IntegratedSecurityCB.Size = new System.Drawing.Size(125, 19);
            this.IntegratedSecurityCB.TabIndex = 10;
            this.IntegratedSecurityCB.Text = "Integrated Security";
            this.IntegratedSecurityCB.UseVisualStyleBackColor = true;
            this.IntegratedSecurityCB.CheckedChanged += new System.EventHandler(this.IntegratedSecurityCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(6, 318);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(238, 32);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Serverlabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox IntegratedSecurityCB;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox userIDtxt;
        private System.Windows.Forms.Label useridlabel;
        private System.Windows.Forms.TextBox DataBasetxt;
        private System.Windows.Forms.Label Databaselabel;
        private System.Windows.Forms.TextBox Servertxt;
    }
}