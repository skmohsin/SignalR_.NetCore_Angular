using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signalrsample.Hubs;
using signalrsample.Models;

namespace signalrsample.Controllers
{
    [Route("api/message")]
    public class MessageController : Controller 
    {
        private IHubContext<MessageHub> _messageHubContext;

        List<Employee> employees = new List<Employee>(){
            new Employee { Id = 1, Name = "Mohsin", Address= "Jalgaon"},
            new Employee { Id = 2, Name = "Shahid", Address="Pune"},
            new Employee { Id = 3, Name = "Sachin", Address = "Mumbai"}
        };
        public MessageController(IHubContext<MessageHub> messageHubContext)
        {
            _messageHubContext = messageHubContext;
        }
        public IActionResult Post(){
            _messageHubContext.Clients.All.SendAsync("topic", employees);
            return Ok();
        }
    }
}