using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS_TEAMS.Models;
using MS_TEAMS.Services.Messages;
using MS_TEAMS.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEAMS.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet("{GroupId}")]
        public IActionResult GetMessages(int GroupId)
        {

            var messages = _messageService.AllMessages(GroupId);
            if (messages is null) return NotFound();
            var mappedMessages = _mapper.Map<ICollection<MessageDto>>(messages);
            
            return Ok(mappedMessages);
            
        }

        [HttpGet("{GroupId}/{id}", Name ="GetMessage")]
        public IActionResult GetMessage(int GroupId,int id)
        {
            var msg = _messageService.getMessages(GroupId,id);
            if (msg is null) return NotFound();
            var mappedMessage = _mapper.Map<MessageDto>(msg);
            return Ok(mappedMessage);

        }
        [HttpPost]
        public ActionResult<MessageDto> SendMessage(SendMessageDto message)
        {
            var messageEntity = _mapper.Map<Message>(message);
            var newMessage = _messageService.SendMessage(messageEntity);
            var messageForReturn = _mapper.Map<MessageDto>(newMessage);
            //handle the error when someone enter a groupId that is not there - Exception occured
            //handle the error when someone enter a memberId and he or she is not in the team to send the message - no exception occured - Maybe add Team Id to message Model
            return CreatedAtRoute("GetMessage",new { GroupId = messageForReturn.GroupId, id = messageForReturn.Id }, messageForReturn);
        }


    }
}
