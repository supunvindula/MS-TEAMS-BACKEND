using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.Members
{
    public interface IMemberRepository
    {
        public List<Member> GetMembers();
        public Member GetMember(int id);
    }
}
