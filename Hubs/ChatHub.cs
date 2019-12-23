using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace VIA3_Online_School.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}