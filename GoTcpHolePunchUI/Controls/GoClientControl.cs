using System;
using System.Windows.Forms;
using GoTcpHolePunching;

namespace GoTcpHolePunchUI
{
    public partial class GoClientControl : UserControl
    {
        public GoClientControl(GoClientConnector client)
        {
            InitializeComponent();
            Client = client;
            Client.MessageArrived += OnNewMessageReceived;
            Client.MessageSent += OnNewMessageSent;
            Client.ConnectionStateChanged += OnClientStateChanged;
            bottomPanel.Enabled = Client.IsConnected;
            ClientNameLbl.Text = $@"{client.ClientID} : {client.ClientData.RemoteEP}";
        }

        public event EventHandler<String> ConnectTriggered;

        public GoClientConnector Client { get; }

        protected virtual void OnConnectTriggered(String e)
        {
            ConnectTriggered?.Invoke(this, e);
        }

        private void OnNewMessageSent(Object sender, String e)
        {
            //BeginInvoke(new MethodInvoker(() => messageTxtBx.AppendText($"You : {e}{Environment.NewLine}")));
        }

        private void OnClientStateChanged(Object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                bottomPanel.Enabled = Client.IsConnected;
                ConnectBtn.Visible = !Client.IsConnected;
            }));
        }

        private void OnNewMessageReceived(Object sender, String e)
        {
            BeginInvoke(new MethodInvoker(() => messageTxtBx.AppendText($"{Client.ClientID} : {e}{Environment.NewLine}")));
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            String sendText = SendMsgTxtBx.Text.Trim(Environment.NewLine.ToCharArray());
            Client.ConnectedSocket.Send(sendText);
            messageTxtBx.AppendText($"You : {sendText}{Environment.NewLine}");
            SendMsgTxtBx.Clear();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            OnConnectTriggered(Client.ClientID);
        }
    }
}
