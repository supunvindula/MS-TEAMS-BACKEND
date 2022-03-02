using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        public string email { get; set; }
        public virtual ICollection<MemberTeam> MemberTeams { get; set; }
    }
}
