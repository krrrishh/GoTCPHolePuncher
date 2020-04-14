using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using GoTcpHolePunching;

namespace GoTcpHolePunchUI
{
    public partial class GoTcpClientForm : Form
    {
        public GoTcpClientForm()
        {
            InitializeComponent();
        }

        private readonly Dictionary<String, ClientControlHolder> Holders = new Dictionary<String, ClientControlHolder>();

        private GoHolePunchTcpClient goClient;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            connectPanel.Location = new Point((Width / 2) - (connectPanel.Width / 2), (Height / 2) - (connectPanel.Height / 2));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            foreach (KeyValuePair<String, ClientControlHolder> clientControlHolder in Holders)
            {
                clientControlHolder.Value.Control.Client.ConnectedSocket?.ShutdownAndClose();
            }
            goClient?.ServerConnector.ShutdownAndClose();
            goClient?.Listener.ShutdownAndClose();
        }

        private void OnGoBtnClick(object sender, EventArgs e)
        {
            IPAddress[] addresses = Dns.GetHostAddresses(hostTextBox.Text);
            if (addresses.Length == 0) return;
            goClient = new GoHolePunchTcpClient(NameBox.Text, new IPEndPoint(addresses[0], (Int32)portNumericBox.Value));
            goClient.ConnectedToServer += GoClientOnConnectedToServer;
            goClient.ClientAdded += GoClientOnClientAdded;
            goClient.ClientRemoved += GoClientOnClientRemoved;
            goClient.ConnectionStateChanged += ConnectionStateChanged;
            goClient.BeginConnectionToServer();
        }

        private void GoClientOnConnectedToServer(Object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                connectPanel.Visible = false;
                masterPanel.Visible = true;
                connectedStatusPanel.BackColor = Color.Green;
                Text = $@"Connected as : {goClient.ClientName}";
            }));
        }

        private void ConnectionStateChanged(Object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() => connectedStatusPanel.BackColor = goClient.ServerConnected ? Color.Green : Color.Red));
        }

        private void GoClientOnClientRemoved(Object sender, GoClientDetails e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                if (!Holders.ContainsKey(e.ID)) return;
                ClientControlHolder holder = Holders[e.ID];
                holder.Control.ConnectTriggered -= OnConnectionTriggered;
                connectionsTabControl.TabPages.Remove(holder.ParentTab);
                Holders.Remove(e.ID);
                holder.Dispose();
            }));
        }

        private void OnConnectionTriggered(Object sender, String e)
        {
            goClient.SendConnectionRequest(e);
        }

        private void GoClientOnClientAdded(Object sender, GoClientDetails e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                if (Holders.ContainsKey(e.ID)) return;
                ClientControlHolder holder = new ClientControlHolder(goClient.ClientDetails[e.ID]);
                holder.Control.ConnectTriggered += OnConnectionTriggered;
                connectionsTabControl.TabPages.Add(holder.ParentTab);
                Holders.Add(e.ID, holder);
            }));
        }

        public class ClientControlHolder : IDisposable
        {
            public ClientControlHolder(GoClientConnector connector)
            {
                ClientID = connector.ClientID;
                ParentTab = new TabPage(ClientID);
                Control = new GoClientControl(connector) { Dock = DockStyle.Fill };
                ParentTab.Controls.Add(Control);
            }

            public String ClientID { get; }

            public GoClientControl Control { get; }

            public TabPage ParentTab { get; }

            public void Dispose()
            {
                ParentTab?.Dispose();
                Control?.Dispose();
                Control?.Client?.ConnectedSocket?.ShutdownAndClose();
            }
        }
    }
}
