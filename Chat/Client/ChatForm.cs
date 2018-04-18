using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Transports;

namespace Client
{
    public partial class ChatForm : Form
    {
        public const string _serverAddress = "http://127.0.0.1:8080/signalr";
        private static HubConnection _hubConnection { get; set; }
        private IHubProxy _proxy { get; set; }
        private ChatMember _member { get; set; }
        public ChatForm(ChatMember chatMember, Form newUser)
        {
            InitializeComponent();
            newUser.Hide();
            _member = chatMember;
            SetChatWindowName();
            ConnectToServerAsync();
        }
        private void SetChatWindowName()
        {
            Text = _member.Name;
        }
        private async void ConnectToServerAsync()
        {
            _hubConnection = new HubConnection(_serverAddress);
            _proxy = _hubConnection.CreateHubProxy("ChatHub");

            _proxy.On<string, string>("BroadCastMessage", (name, message) =>
                Invoke((Action)(() => ReceiveMessage(name, message))));
            try
            {
                await _hubConnection.Start();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Attempt to connect failed! \r\n Reconnect ?", "Connection failure", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                    ConnectToServerAsync();
                else
                    Close();
            }
        }
        private void bttnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(txtClientMessage.Text);
                var message = Encoding.UTF8.GetString(bytes);
                
                _proxy.Invoke("SendMessage", _member.Name, message);
                txtClientMessage.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Client failed to send message!", "Sending failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReceiveMessage(string name, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            var encodedMsg = Encoding.UTF8.GetString(bytes);

            txtClientOutput.AppendText($"{name} says: {encodedMsg}\r\n");
            txtClientOutput.ScrollToCaret();
        }
        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hubConnection?.Dispose();
        }

        private void txtClientMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bttnSend.PerformClick();
            }
        }
    }
}
