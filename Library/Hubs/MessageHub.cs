using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRLibrary.Hubs
{
    public class MessageHub : Hub
    {

        public static void BroadcastData()
        {

        }
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}