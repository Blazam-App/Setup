﻿namespace WixSharpSetup
{
    partial class IISSettingsDialog
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
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.httpPortInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.sslCertLabel = new System.Windows.Forms.Label();
            this.httpsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.httpsPortInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.httpPortInput)).BeginInit();
            this.httpsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.httpsPortInput)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Configure the site that will be created in IIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "IIS Settings";
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
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(15, 79);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(220, 21);
            this.hostnameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Website FQDN (leave blank for server name)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "HTTP Port";
            // 
            // httpPortInput
            // 
            this.httpPortInput.Location = new System.Drawing.Point(16, 124);
            this.httpPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.httpPortInput.Name = "httpPortInput";
            this.httpPortInput.Size = new System.Drawing.Size(120, 21);
            this.httpPortInput.TabIndex = 14;
            this.httpPortInput.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.httpPortInput.ValueChanged += new System.EventHandler(this.httpPortInput_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "SSL Certificate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sslCertLabel
            // 
            this.sslCertLabel.AutoSize = true;
            this.sslCertLabel.Location = new System.Drawing.Point(115, 172);
            this.sslCertLabel.Name = "sslCertLabel";
            this.sslCertLabel.Size = new System.Drawing.Size(0, 13);
            this.sslCertLabel.TabIndex = 16;
            // 
            // httpsPanel
            // 
            this.httpsPanel.Controls.Add(this.httpsPortInput);
            this.httpsPanel.Controls.Add(this.label5);
            this.httpsPanel.Location = new System.Drawing.Point(16, 197);
            this.httpsPanel.Name = "httpsPanel";
            this.httpsPanel.Size = new System.Drawing.Size(200, 100);
            this.httpsPanel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "HTTPS Port";
            // 
            // httpsPortInput
            // 
            this.httpsPortInput.Location = new System.Drawing.Point(0, 20);
            this.httpsPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.httpsPortInput.Name = "httpsPortInput";
            this.httpsPortInput.Size = new System.Drawing.Size(120, 21);
            this.httpsPortInput.TabIndex = 18;
            this.httpsPortInput.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            this.httpsPortInput.ValueChanged += new System.EventHandler(this.httpsPortInput_ValueChanged);
            // 
            // IISSettingsDialog
            // 
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.httpsPanel);
            this.Controls.Add(this.sslCertLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.httpPortInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostnameTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IISSettingsDialog";
            this.Text = "[UserNameDlg_Title]";
            this.Load += new System.EventHandler(this.dialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.httpPortInput)).EndInit();
            this.httpsPanel.ResumeLayout(false);
            this.httpsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.httpsPortInput)).EndInit();
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
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown httpPortInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sslCertLabel;
        private System.Windows.Forms.Panel httpsPanel;
        private System.Windows.Forms.NumericUpDown httpsPortInput;
        private System.Windows.Forms.Label label5;
    }
}