using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System.Windows.Forms;
using System;
namespace Server
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.BroadCastMessage(name, message);
        }

    }
}