using System;
using System.Windows.Forms;

namespace GoTcpHolePunchUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TCPServer_Click(object sender, EventArgs e)
        {
            new GoTCPServerForm().Show(this);
        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            new GoTcpClientForm().Show(this);
        }
    }
}
