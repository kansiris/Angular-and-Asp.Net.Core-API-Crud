using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccessLayer;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{


    [EnableCors("AllowOrigin")]
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {

        private readonly IContact objcontact;

        public ContactController(IContact _objcontact)
        {
            objcontact = _objcontact;

        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<TblContact> Index() {
            return objcontact.GetContacts();
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] TblContact contact) { 
            return objcontact.AddContacts(contact);
        }
        [HttpGet]
        [Route("GetContactId/{id}")]
        public TblContact GetContactId(int id) {
        return objcontact.GetContactId(id);
        }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody] TblContact contact) {
            return objcontact.UpdateContacts(contact);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id) { 
        return objcontact.DeleteContacts(id);
        }

    }
}
