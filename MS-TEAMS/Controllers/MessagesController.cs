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
using Microsoft.AspNetCore.SignalR;
using MS_TEAMS.Services.SignalR;

namespace MS_TEAMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageRepository _messageService;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotifyHub, ItypedHubClient> _hubContext;
        public MessagesController(IMessageRepository _repository, IMapper mapper,IHubContext<NotifyHub, ItypedHubClient> hubContext)
        {
            _messageService = _repository;
            _mapper = mapper;
            _hubContext = hubContext;
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
        public async Task<ActionResult<MessageDto>> SendMessageAsync(SendMessageDto message)
        {
            var messageEntity = _mapper.Map<Message>(message);
            var newMessage = _messageService.SendMessage(messageEntity);
            var messageForReturn = _mapper.Map<MessageDto>(newMessage);
            await _hubContext.Clients.All.BroadcastMessage("updated");

            //handle the error when someone enter a groupId that is not there - Exception occured
            //handle the error when someone enter a memberId and he or she is not in the team to send the message - no exception occured - Maybe add Team Id to message Model

            return CreatedAtRoute("GetMessage",new { GroupId = messageForReturn.GroupId, id = messageForReturn.Id }, messageForReturn);
        }

        [HttpPut("{GroupId}/{MemberId}/{MessageId}")]
        public async Task<ActionResult> EditMessageAsync(int GroupId,int MemberId, int MessageId,EditMessageDto message)
        {
            var updatingMessage = _messageService.getMessage(GroupId, MemberId,MessageId);
            if (updatingMessage is null)
            {
                return NotFound();
            }
            _mapper.Map(message, updatingMessage);
            _messageService.EditMessage(updatingMessage);
            await _hubContext.Clients.All.BroadcastMessage("updated");
            return NoContent();
            
        }

        [HttpDelete("{GroupId}/{MemberId}/{MessageId}")]
        public async Task<ActionResult> DeleteMessageAsync(int GroupId, int MemberId, int MessageId)
        {
            var deletingMessage = _messageService.getMessage(GroupId, MemberId, MessageId);
            if (deletingMessage is null)
            {
                return NotFound();
            }
            _messageService.DeleteMessage(deletingMessage);
            await _hubContext.Clients.All.BroadcastMessage("updated");
            return NoContent();
        }


    }
}
