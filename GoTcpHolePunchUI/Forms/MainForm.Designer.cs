namespace GoTcpHolePunchUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TCPServer = new System.Windows.Forms.Button();
            this.TCPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCPServer
            // 
            this.TCPServer.Dock = System.Windows.Forms.DockStyle.Left;
            this.TCPServer.Location = new System.Drawing.Point(0, 0);
            this.TCPServer.Name = "TCPServer";
            this.TCPServer.Size = new System.Drawing.Size(114, 74);
            this.TCPServer.TabIndex = 3;
            this.TCPServer.Text = "Tcp Server";
            this.TCPServer.UseVisualStyleBackColor = true;
            this.TCPServer.Click += new System.EventHandler(this.TCPServer_Click);
            // 
            // TCPClient
            // 
            this.TCPClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.TCPClient.Location = new System.Drawing.Point(128, 0);
            this.TCPClient.Name = "TCPClient";
            this.TCPClient.Size = new System.Drawing.Size(114, 74);
            this.TCPClient.TabIndex = 4;
            this.TCPClient.Text = "Tcp Client";
            this.TCPClient.UseVisualStyleBackColor = true;
            this.TCPClient.Click += new System.EventHandler(this.TCPClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 74);
            this.Controls.Add(this.TCPClient);
            this.Controls.Add(this.TCPServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TCPServer;
        private System.Windows.Forms.Button TCPClient;
    }
}