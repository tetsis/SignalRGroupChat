using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRGroupChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToGroup(string group, string user, string message)
        {
            await Clients.Group(group).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
