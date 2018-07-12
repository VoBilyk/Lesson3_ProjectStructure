using System;
using Microsoft.AspNetCore.Mvc;
using Airport.BLL.Interfaces;
using Airport.Shared.DTO;


namespace Airport.API.Controllers
{
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        IService<TicketDto> ticketService;
        public TicketsController(IService<TicketDto> ticketService)
        {
            this.ticketService = ticketService;
        }

        // GET: api/tickets
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ticketService.GetAll());
        }

        // GET: api/tickets/:id
        [HttpGet("{id}")]
        public IActionResult Get(Guid? id)
        {
            var item = ticketService.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST api/tickets
        [HttpPost]
        public IActionResult Post([FromBody]TicketDto item)
        {
            try
            {
                return Ok(ticketService.Create(item));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Type = nameof(ex), Message = "Can`t create ticket" });
            }
        }

        // PUT api/tickets
        [HttpPut("{id}")]
        public void Put(Guid? id, [FromBody]TicketDto item)
        {
            try
            {
                return Ok(ticketService.Update(item));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Type = nameof(ex), Message = "Can`t update ticket" });
            }
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            try
            {
                ticketService.DeleteAll();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Type = nameof(ex), Message = "Can`t delete tickets" });
            }
            
            return NoContent();
        }

        // DELETE api/tickets/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id)
        {
            try
            {
                ticketService.Delete(id);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Type = nameof(ex), Message = "Can`t delete tickets" });
            }

            return NoContent();
        }
    }
}
