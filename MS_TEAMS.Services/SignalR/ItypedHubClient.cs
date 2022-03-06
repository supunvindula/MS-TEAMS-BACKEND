using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.SignalR
{
    public interface ItypedHubClient
    {
        Task BroadcastMessage(string message);
    }
}
