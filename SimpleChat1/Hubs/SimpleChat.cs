using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SimpleChat1.Hubs
{
    public class SimpleChat:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
