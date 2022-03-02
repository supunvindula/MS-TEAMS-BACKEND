using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Models
{
    public class MemberTeam
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int TeamId { get; set; }
        public virtual Member Member { get; set; }
        public virtual Team Team { get; set; }
    }
}
