using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class DemoHub : Hub
    {
        public async Task Adder(int a, int b, int c)
        {
            int sum = a + b + c;
            await Clients.All.SendAsync("ReceiveMessage", sum);
        }

        /*
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        */
    }
}