﻿namespace WixSharpSetup
{
    partial class DatabaseTypeDialog
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
            this.banner = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sqliteRadioButton = new System.Windows.Forms.RadioButton();
            this.sqlRadioButton = new System.Windows.Forms.RadioButton();
            this.mysqlRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.White;
            this.banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(501, 59);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.banner);
            this.panel2.Location = new System.Drawing.Point(-5, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 61);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom Dialog Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Dialog";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Location = new System.Drawing.Point(-3, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 57);
            this.panel1.TabIndex = 9;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(227, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "[WixUIBack]";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(308, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 0;
            this.next.Text = "[WixUINext]";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(404, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "[WixUICancel]";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Please choose the database type to use";
            // 
            // sqliteRadioButton
            // 
            this.sqliteRadioButton.AutoSize = true;
            this.sqliteRadioButton.Location = new System.Drawing.Point(29, 90);
            this.sqliteRadioButton.Name = "sqliteRadioButton";
            this.sqliteRadioButton.Size = new System.Drawing.Size(437, 17);
            this.sqliteRadioButton.TabIndex = 12;
            this.sqliteRadioButton.TabStop = true;
            this.sqliteRadioButton.Text = "File-Based (SQLite) [Acceptable for installations with up to 20 simultaneous app " +
    "users]";
            this.sqliteRadioButton.UseVisualStyleBackColor = true;
            this.sqliteRadioButton.CheckedChanged += new System.EventHandler(this.sqliteRadioButton_CheckedChanged);
            // 
            // sqlRadioButton
            // 
            this.sqlRadioButton.AutoSize = true;
            this.sqlRadioButton.Location = new System.Drawing.Point(29, 114);
            this.sqlRadioButton.Name = "sqlRadioButton";
            this.sqlRadioButton.Size = new System.Drawing.Size(217, 17);
            this.sqlRadioButton.TabIndex = 13;
            this.sqlRadioButton.TabStop = true;
            this.sqlRadioButton.Text = "SQL Database (SQLExpress Compatible)";
            this.sqlRadioButton.UseVisualStyleBackColor = true;
            this.sqlRadioButton.CheckedChanged += new System.EventHandler(this.sqlRadioButton_CheckedChanged);
            // 
            // mysqlRadioButton
            // 
            this.mysqlRadioButton.AutoSize = true;
            this.mysqlRadioButton.Location = new System.Drawing.Point(29, 137);
            this.mysqlRadioButton.Name = "mysqlRadioButton";
            this.mysqlRadioButton.Size = new System.Drawing.Size(213, 17);
            this.mysqlRadioButton.TabIndex = 14;
            this.mysqlRadioButton.TabStop = true;
            this.mysqlRadioButton.Text = "MySQL Database (MariaDB Compatible)";
            this.mysqlRadioButton.UseVisualStyleBackColor = true;
            this.mysqlRadioButton.CheckedChanged += new System.EventHandler(this.mysqlRadioButton_CheckedChanged);
            // 
            // DatabaseTypeDialog
            // 
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.mysqlRadioButton);
            this.Controls.Add(this.sqlRadioButton);
            this.Controls.Add(this.sqliteRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DatabaseTypeDialog";
            this.Text = "[UserNameDlg_Title]";
            this.Load += new System.EventHandler(this.dialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sqliteRadioButton;
        private System.Windows.Forms.RadioButton sqlRadioButton;
        private System.Windows.Forms.RadioButton mysqlRadioButton;
    }
}