using Microsoft.AspNetCore.Mvc;

namespace REST_API_NET.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]

    public class AccountController : ControllerBase
    {
        [HttpGet("{client_id}/{account_number}")]
        public IActionResult GetAccountStatus(int client_id, string account_number)
        {
            return Ok(client_id);
        }

        [HttpGet("{client_id}")]
        public IActionResult GetTransactionsHistories(int client_id)
        {
            return Ok("SI");
        }

        [HttpPost]
        public ActionResult PostTransaction()
        {
            int textString = 56;
            return Ok(textString);
        }
    }
}
