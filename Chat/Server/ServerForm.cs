using Microsoft.Owin.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        private const string _serverAdress = "http://127.0.0.1:8080";
        private IDisposable _disconnect;
        public ServerForm()
        {
            InitializeComponent();
            StartServer();
        }
        public void StartServer()
        {
            try
            {
                _disconnect = WebApp.Start(_serverAdress);
            }
            catch (Exception)
            {
                MessageBox.Show("Server failed to start", "Server start failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServerOutput.AppendText("Server failed to start at: " + _serverAdress + " !\r\n");
                return;
            }
            txtServerOutput.AppendText("Server successfully started at: " + _serverAdress + " !\r\n");
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _disconnect.Dispose();
        }
    }
}
