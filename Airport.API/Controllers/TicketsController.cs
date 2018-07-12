using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.BLL.Interfaces;
using Airport.Shared.DTO;


namespace Airport.API.Controllers
{
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        ITicketService ticketService;
        public TicketsController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        // GET: api/tickets
        [HttpGet]
        public IEnumerable<TicketDto> Get()
        {
            return ticketService.GetTickets();
        }

        // GET: api/tickets/:id
        [HttpGet("{id}")]
        public TicketDto Get(Guid? id)
        {
            return ticketService.GetTicket(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
