using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime created { get; set; }
        //public MessageStatus status { get; set; }
       

    }
}

/*
public enum MessageStatus 
{
    sent,
    delivered,
    read
}*/