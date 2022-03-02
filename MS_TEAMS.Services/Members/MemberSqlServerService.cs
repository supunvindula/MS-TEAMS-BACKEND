using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_TEAMS.DataAccess;

namespace MS_TEAMS.Services.Members
{
    public class MemberSqlServerService : IMemberRepository
    {
        private readonly MessageDBContext _context = new MessageDBContext();
        public Member GetMember(int id)
        {
            return _context.Members.Find(id);
        }

        public List<Member> GetMembers()
        {
            return _context.Members.ToList();
        }
    }
}
