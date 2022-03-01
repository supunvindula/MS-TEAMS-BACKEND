using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services
{
    public interface IMessageRepository
    {
        public List<Message> AllMessages();
    }
}
