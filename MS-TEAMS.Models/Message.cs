using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(5000)]
        public string MessageBody { get; set; }
        [Required]
        public DateTime created { get; set; }
        //public MessageStatus status { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int GroupId { get; set; }
        //public Group Group { get; set; }

    }
}

/*
public enum MessageStatus 
{
    sent,
    delivered,
    read
}*/