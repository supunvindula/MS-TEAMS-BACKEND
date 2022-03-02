﻿using MS_TEAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.Messages
{
    public class MessageService : IMessageRepository
    {
        public List<Message> AllMessages()
        {
            var messages = new List<Message>();
            var message1 = new Message
            {
                Id = 1,
                MessageBody = "Hello Everyone",
                created = DateTime.Now
            };
            messages.Add(message1);
            var message2 = new Message
            {
                Id = 2,
                MessageBody = "Helloo!!",
                created = DateTime.Now
            };
            messages.Add(message2);
            var message3 = new Message
            {
                Id = 3,
                MessageBody = "Hii all!!",
                created = DateTime.Now
            };
            messages.Add(message3);
            return messages;
        }

        public List<Message> AllMessages(int GroupId)
        {
            throw new NotImplementedException();
        }

        public List<Message> getMessages(int GroupId, int MemberId)
        {
            throw new NotImplementedException();
        }
    }
}