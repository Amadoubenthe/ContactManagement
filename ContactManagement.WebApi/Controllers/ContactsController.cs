using ContactManagement.BusinessLogic.Interfaces;
using ContactManagement.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContact _ContactService;
        public ContactsController(IContact ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ContactService.GetContacts());
        }

        [HttpPost]
        public async Task<IActionResult> AddContactAsync([FromBody] ContactRequest contactRequest)
        {
           var contact = await _ContactService.AddContactsAsync(contactRequest);

            return Ok(contact);

        }


    }
}
