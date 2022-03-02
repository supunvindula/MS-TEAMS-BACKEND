using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS_TEAMS.Services.Messages;
using MS_TEAMS.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Controllers
{
    [Route("api/groups/{GroupId}/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageRepository _messageService;
        private readonly IMapper _mapper;
        public MessagesController(IMessageRepository _repository, IMapper mapper)
        {
            _messageService = _repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetMessages(int GroupId)
        {

            var messages = _messageService.AllMessages(GroupId);
            if (messages is null) return NotFound();
            var mappedMessages = _mapper.Map<ICollection<MessageDto>>(messages);
            
            return Ok(mappedMessages);
            
        }

        [HttpGet("{id?}")]
        public IActionResult GetMessage(int GroupId,int id)
        {
            var msg = _messageService.getMessages(GroupId,id);
            if (msg is null) return NotFound();
            var mappedMessage = _mapper.Map<MessageDto>(msg);
            return Ok(mappedMessage);

        }
    }
}
