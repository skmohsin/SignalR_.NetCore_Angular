using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalrsample.Hubs
{
    public class MessageHub: Hub {
        public Task Send(string message) {
            return Clients.All.SendAsync("topic", message);
        }
    }
} 