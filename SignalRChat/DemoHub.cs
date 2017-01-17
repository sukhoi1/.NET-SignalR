using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class DemoHub : Hub
    {
        public void Post(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.demoMessage(name, message);
        }
    }
}