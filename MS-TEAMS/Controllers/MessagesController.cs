using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS_TEAMS.Services;
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
        public MessagesController(IMessageRepository _repository)
        {
            _messageService = _repository;
        }
        [HttpGet("{id?}")]
        public IActionResult GetMessages(int? id)
        {

            var messages = _messageService.AllMessages();
            if(id is null)
            {
                return Ok(messages);
            }
            messages = messages.Where(m => m.Id == id).ToList();
            return Ok(messages);
        }

        private object AllMessages()
        {
            throw new NotImplementedException();
        }
    }
}
