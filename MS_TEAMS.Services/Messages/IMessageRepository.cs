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
        public Message getMessage(int GroupId, int MemberId, int MessageId);
        public Message SendMessage(Message message);
        public void EditMessage(Message message);
        public void DeleteMessage(Message message);
    }
}
