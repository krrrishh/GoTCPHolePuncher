namespace GoTcpHolePunchUI
{
    partial class GoTCPServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoTCPServerForm));
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.Black;
            this.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(493, 605);
            this.ConsoleBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.portBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 24);
            this.panel1.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBtn.Location = new System.Drawing.Point(178, 0);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(625, 24);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start Server";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.OnStartBtnClick);
            // 
            // portBox
            // 
            this.portBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.portBox.Location = new System.Drawing.Point(96, 0);
            this.portBox.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(82, 20);
            this.portBox.TabIndex = 0;
            this.portBox.Value = new decimal(new int[] {
            8082,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataListBox);
            this.panel2.Controls.Add(this.countLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(493, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 605);
            this.panel2.TabIndex = 2;
            // 
            // DataListBox
            // 
            this.DataListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(0, 0);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(310, 573);
            this.DataListBox.TabIndex = 3;
            // 
            // countLbl
            // 
            this.countLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.countLbl.Location = new System.Drawing.Point(0, 573);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(310, 32);
            this.countLbl.TabIndex = 4;
            this.countLbl.Text = "Clients : 0 \r\nRegistered : 0";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Open Port ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoTCPServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 629);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoTCPServerForm";
            this.Text = "Go Server Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label1;
    }
}