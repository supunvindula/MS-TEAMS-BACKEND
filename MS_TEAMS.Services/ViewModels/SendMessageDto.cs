using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.ViewModels
{
    public class SendMessageDto
    {
        public string MessageBody { get; set; }
        public DateTime created { get; set; }
        public int MemberId { get; set; }
        //public Member Member { get; set; }
        public int GroupId { get; set; }
        //public Group Group { get; set; }
    }
}
