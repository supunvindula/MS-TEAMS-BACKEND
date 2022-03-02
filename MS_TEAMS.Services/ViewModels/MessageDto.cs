using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.ViewModels
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime created { get; set; }
        public int MemberId { get; set; }
        //public Member Member { get; set; }
        public int GroupId { get; set; }
        //public Group Group { get; set; }
    }
}
