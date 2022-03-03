using AutoMapper;
using MS_TEAMS.Models;
using MS_TEAMS.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TEAMS.Services.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<Message, MessageDto>();
            CreateMap<SendMessageDto, Message>();
            CreateMap<EditMessageDto, Message>();
        }
    }
}
