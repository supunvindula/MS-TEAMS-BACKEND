using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.Messages
{
    public interface IMessageRepository
    {
        public List<Message> AllMessages(int GroupId);
        public List<Message> getMessages(int GroupId, int MemberId);
    }
}
