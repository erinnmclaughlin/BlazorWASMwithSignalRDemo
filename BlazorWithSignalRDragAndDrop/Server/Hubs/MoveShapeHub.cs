using BlazorWithSignalRDragAndDrop.Shared;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BlazorWithSignalRDragAndDrop.Server.Hubs
{
    public class MoveShapeHub : Hub
    {
        public async Task SendShapeUpdate(GridModel gridModel)
        {
            await Clients.All.SendAsync("ReceiveShapeUpdate", gridModel);
        }
    }
}
