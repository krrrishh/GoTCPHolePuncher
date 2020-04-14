using System;
using System.Windows.Forms;
using GoTcpHolePunching;

namespace GoTcpHolePunchUI
{
    public partial class GoTCPServerForm : Form
    {
        public GoTCPServerForm()
        {
            InitializeComponent();
        }

        private GoHolePunchTcpServer holePuncher;

        private void OnStartBtnClick(object sender, EventArgs e)
        {
            if (holePuncher != null)
            {
                holePuncher.CloseServer();
                Application.Exit();
                return;
            }
            holePuncher = new GoHolePunchTcpServer((Int32) portBox.Value);
            holePuncher.ConsoleEvent += OnConsoleMessageThrown;
            holePuncher.ClientRegistered += ClientRegistered;
            holePuncher.ClientRemoved += ClientRemoved;
            holePuncher.CountUpdated += HolePuncherOnCountUpdated;
            holePuncher.StartServer();
            portBox.Enabled = false;
            StartBtn.Text = @"Stop Server";
        }

        private void HolePuncherOnCountUpdated(Object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(UpdateCount));
        }

        private void UpdateCount()
        {
            countLbl.Text = $@"Clients : {holePuncher.ClientCount}{Environment.NewLine}Registered : {holePuncher.RegisteredCount}";
        }

        private void ClientRemoved(Object sender, String e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                DataListBox.Items.Remove(e);
                UpdateCount();
            }));
        }

        private void ClientRegistered(Object sender, String e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                DataListBox.Items.Add(e);
                UpdateCount();
            }));
        }

        private void OnConsoleMessageThrown(Object sender, String e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                ConsoleBox.AppendText(Environment.NewLine + e);
                //ConsoleBox.ScrollToCaret();
            }));
        }
    }
}
