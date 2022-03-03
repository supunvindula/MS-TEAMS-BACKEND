using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_TEAMS.DataAccess;

namespace MS_TEAMS.Services.Messages
{
    public class MessageSqlServerService : IMessageRepository
    {
        private readonly MessageDBContext _context = new MessageDBContext();
        public List<Message> AllMessages(int GroupId)
        {
            return _context.Messages.Where(m => m.GroupId == GroupId).ToList();
        }

        public List<Message> getMessages(int GroupId, int MemberId)
        {
            return _context.Messages.Where(m => (m.GroupId==GroupId) && (m.MemberId == MemberId)).ToList();
        }

        public Message SendMessage(Message message)
        {
            if(message != null)
            {
                _context.Messages.Add(message);
                _context.SaveChanges();
                return _context.Messages.Find(message.Id);
            }
            return null;
        }
    }
}
