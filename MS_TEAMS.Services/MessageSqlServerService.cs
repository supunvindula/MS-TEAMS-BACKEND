using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_TEAMS.DataAccess;

namespace MS_TEAMS.Services
{
    public class MessageSqlServerService : IMessageRepository
    {
        private readonly MessageDBContext _context = new MessageDBContext();
        public List<Message> AllMessages()
        {
            return _context.Messages.ToList();
        }
    }
}
