namespace GoTcpHolePunchUI
{
    partial class GoClientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientNameLbl = new System.Windows.Forms.Label();
            this.messageTxtBx = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.SendMsgTxtBx = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientNameLbl
            // 
            this.ClientNameLbl.BackColor = System.Drawing.Color.DimGray;
            this.ClientNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientNameLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLbl.ForeColor = System.Drawing.Color.White;
            this.ClientNameLbl.Location = new System.Drawing.Point(0, 0);
            this.ClientNameLbl.Name = "ClientNameLbl";
            this.ClientNameLbl.Size = new System.Drawing.Size(682, 26);
            this.ClientNameLbl.TabIndex = 0;
            this.ClientNameLbl.Text = "ClientName";
            this.ClientNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageTxtBx
            // 
            this.messageTxtBx.BackColor = System.Drawing.Color.White;
            this.messageTxtBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTxtBx.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTxtBx.Location = new System.Drawing.Point(0, 26);
            this.messageTxtBx.Multiline = true;
            this.messageTxtBx.Name = "messageTxtBx";
            this.messageTxtBx.ReadOnly = true;
            this.messageTxtBx.Size = new System.Drawing.Size(743, 623);
            this.messageTxtBx.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.SendMsgTxtBx);
            this.bottomPanel.Controls.Add(this.SendBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 649);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(743, 64);
            this.bottomPanel.TabIndex = 2;
            // 
            // SendMsgTxtBx
            // 
            this.SendMsgTxtBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMsgTxtBx.Location = new System.Drawing.Point(0, 0);
            this.SendMsgTxtBx.Multiline = true;
            this.SendMsgTxtBx.Name = "SendMsgTxtBx";
            this.SendMsgTxtBx.Size = new System.Drawing.Size(670, 62);
            this.SendMsgTxtBx.TabIndex = 0;
            // 
            // SendBtn
            // 
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendBtn.Location = new System.Drawing.Point(670, 0);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(71, 62);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.ClientNameLbl);
            this.topPanel.Controls.Add(this.ConnectBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(743, 26);
            this.topPanel.TabIndex = 3;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Location = new System.Drawing.Point(682, 0);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(61, 26);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // GoClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageTxtBx);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "GoClientControl";
            this.Size = new System.Drawing.Size(743, 713);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLbl;
        private System.Windows.Forms.TextBox messageTxtBx;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TextBox SendMsgTxtBx;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ConnectBtn;
    }
}
