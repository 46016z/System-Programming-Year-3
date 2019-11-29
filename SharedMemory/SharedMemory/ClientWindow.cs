using System;
using System.Windows.Forms;

namespace SharedMemory
{
    public partial class ClientWindow : Form
    {
        private readonly int clientId;
        public event EventHandler ClientMessageSend;

        public ClientWindow(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.Text = $"Client {this.clientId}";
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string message = $"Client {this.clientId}: {this.messageTextBox.Text}";
            IOService.Instance.AppendMessageToChat(message);

            this.ClientMessageSend(this, null);
            this.messageTextBox.Clear();
        }
    }
}
