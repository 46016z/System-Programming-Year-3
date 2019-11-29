using System;
using System.Windows.Forms;

namespace SharedMemory
{
    public partial class MainWindow : Form
    {
        private int clientsCount;

        public MainWindow()
        {
            InitializeComponent();
            this.clientsCount = 0;

            this.UpdateChatHistory();
        }

        public void UpdateChatHistory()
        {
            this.chatHistoryTextbox.Text = IOService.Instance.ReadChatFile();
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow(++this.clientsCount);
            clientWindow.ClientMessageSend += this.OnClientMessageSend;
            clientWindow.FormClosing += (o, i) =>
            {
                clientWindow.ClientMessageSend -= this.OnClientMessageSend;
            };

            clientWindow.Show();
        }

        private void OnClientMessageSend(object sender, EventArgs e)
        {
            this.UpdateChatHistory();
        }
    }
}
