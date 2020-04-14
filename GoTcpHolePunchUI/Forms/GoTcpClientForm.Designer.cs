namespace GoTcpHolePunchUI
{
    partial class GoTcpClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoTcpClientForm));
            this.connectPanel = new System.Windows.Forms.Panel();
            this.connectBottomPanel = new System.Windows.Forms.Panel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.portNumericBox = new System.Windows.Forms.NumericUpDown();
            this.GoBtn = new System.Windows.Forms.Button();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.masterPanel = new System.Windows.Forms.Panel();
            this.connectionsTabControl = new System.Windows.Forms.TabControl();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.serverLbl = new System.Windows.Forms.Label();
            this.connectedStatusPanel = new System.Windows.Forms.Panel();
            this.connectPanel.SuspendLayout();
            this.connectBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericBox)).BeginInit();
            this.masterPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectPanel
            // 
            this.connectPanel.Controls.Add(this.connectBottomPanel);
            this.connectPanel.Controls.Add(this.hostTextBox);
            this.connectPanel.Location = new System.Drawing.Point(335, 283);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(435, 57);
            this.connectPanel.TabIndex = 0;
            // 
            // connectBottomPanel
            // 
            this.connectBottomPanel.Controls.Add(this.NameBox);
            this.connectBottomPanel.Controls.Add(this.portNumericBox);
            this.connectBottomPanel.Controls.Add(this.GoBtn);
            this.connectBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectBottomPanel.Location = new System.Drawing.Point(0, 31);
            this.connectBottomPanel.Name = "connectBottomPanel";
            this.connectBottomPanel.Size = new System.Drawing.Size(435, 26);
            this.connectBottomPanel.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameBox.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Bold);
            this.NameBox.Location = new System.Drawing.Point(59, 0);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(302, 24);
            this.NameBox.TabIndex = 2;
            this.NameBox.Text = "Client Name";
            // 
            // portNumericBox
            // 
            this.portNumericBox.AutoSize = true;
            this.portNumericBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.portNumericBox.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
            this.portNumericBox.Location = new System.Drawing.Point(0, 0);
            this.portNumericBox.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.portNumericBox.Name = "portNumericBox";
            this.portNumericBox.Size = new System.Drawing.Size(59, 25);
            this.portNumericBox.TabIndex = 1;
            this.portNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portNumericBox.Value = new decimal(new int[] {
            8082,
            0,
            0,
            0});
            // 
            // GoBtn
            // 
            this.GoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.GoBtn.Location = new System.Drawing.Point(361, 0);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(74, 26);
            this.GoBtn.TabIndex = 0;
            this.GoBtn.Text = "Connect";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.OnGoBtnClick);
            // 
            // hostTextBox
            // 
            this.hostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.hostTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTextBox.Location = new System.Drawing.Point(0, 0);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(435, 31);
            this.hostTextBox.TabIndex = 0;
            this.hostTextBox.Text = "Enter Your Server Ip/Host Name";
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.connectionsTabControl);
            this.masterPanel.Controls.Add(this.BottomPanel);
            this.masterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterPanel.Location = new System.Drawing.Point(0, 0);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.Size = new System.Drawing.Size(424, 673);
            this.masterPanel.TabIndex = 1;
            this.masterPanel.Visible = false;
            // 
            // connectionsTabControl
            // 
            this.connectionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.connectionsTabControl.Name = "connectionsTabControl";
            this.connectionsTabControl.SelectedIndex = 0;
            this.connectionsTabControl.Size = new System.Drawing.Size(424, 640);
            this.connectionsTabControl.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.serverLbl);
            this.BottomPanel.Controls.Add(this.connectedStatusPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 640);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(424, 33);
            this.BottomPanel.TabIndex = 1;
            // 
            // serverLbl
            // 
            this.serverLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLbl.Location = new System.Drawing.Point(0, 0);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(388, 33);
            this.serverLbl.TabIndex = 1;
            this.serverLbl.Text = "---";
            this.serverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectedStatusPanel
            // 
            this.connectedStatusPanel.BackColor = System.Drawing.Color.Red;
            this.connectedStatusPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.connectedStatusPanel.Location = new System.Drawing.Point(388, 0);
            this.connectedStatusPanel.Name = "connectedStatusPanel";
            this.connectedStatusPanel.Size = new System.Drawing.Size(36, 33);
            this.connectedStatusPanel.TabIndex = 0;
            // 
            // GoTcpClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 673);
            this.Controls.Add(this.masterPanel);
            this.Controls.Add(this.connectPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoTcpClientForm";
            this.Text = "Go TCP Client";
            this.connectPanel.ResumeLayout(false);
            this.connectPanel.PerformLayout();
            this.connectBottomPanel.ResumeLayout(false);
            this.connectBottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericBox)).EndInit();
            this.masterPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel connectPanel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Panel connectBottomPanel;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.NumericUpDown portNumericBox;
        private System.Windows.Forms.Panel masterPanel;
        private System.Windows.Forms.TabControl connectionsTabControl;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel connectedStatusPanel;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.TextBox NameBox;
    }
}