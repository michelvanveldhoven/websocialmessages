using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiSocialMessages.Entities;

namespace WebApiSocialMessages.Controllers
{
    [Route("api/social-messages")]
    [ApiController]
    public class SocialMessagesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<SocialMessage>>> Get()
        {
            return Ok(await Task.FromResult(0));
        }

        // GET api/values/5
        [HttpGet("{social-message-id}")]
        public async Task<ActionResult<SocialMessage>> Get([FromRoute(Name = "social-message-id")]string socialMessageId)
        {
            return Ok(await Task.FromResult(default(SocialMessage)));
        }

        // POST api/values
        [HttpPost]
        public async Task<CreatedResult> Post([FromBody] SocialMessage value)
        {
            return Created(nameof(Get), await Task.FromResult(default(SocialMessage))); ;
        }

        // PUT api/values/5
        [HttpPut("{social-message-id}")]
        public async Task<NoContentResult> Put([FromRoute(Name = "social-message-id")] string socialMessageid, [FromBody] SocialMessage update)
        {
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{social-message-id}")]
        public async Task<NoContentResult> Delete([ FromRoute(Name = "social-message-id")] string socialMessageIdid)
        {
            return NoContent();
        }
    }
}
