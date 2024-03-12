using Bl.BlApi;
using Bl.BlImplemntion;
using Bl.BlObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace project.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressToClientController : ControllerBase
    {
    
    
            IRepo<AddressToClient> AddressToClientRepo;
            public AddressToClientController(IRepo<AddressToClient> AddressToClientRepo)
            {
                this.AddressToClientRepo = AddressToClientRepo;
            }
            [HttpGet]
            public ActionResult<List<AddressToClient>> GetAllAdresses()
            {
                List<AddressToClient> get = AddressToClientRepo.GetAll();
                if (get != null)
                {
                    return get;
                }
                return NotFound();
            }

            [HttpGet("{id}")]
            public ActionResult<AddressToClient> GetByIdAdresses(int id)
            {
            AddressToClient getbyid = AddressToClientRepo.GetById(id);
                if (getbyid != null)
                {
                    return getbyid;
                }
                return NotFound();
            }
            [HttpPost]
            public ActionResult<AddressToClient> AddAdresses(AddressToClient professionalsMan)
            {
            AddressToClient add = AddressToClientRepo.Add(professionalsMan);
                if (add != null)
                {
                    return add;
                }
                return NotFound();
            }
            [HttpPut("{id}")]
            public ActionResult<AddressToClient> UpDateAdresses(int id, AddressToClient professionalsMan,string street,string apartment)
            {
            AddressToClient Update = AddressToClientRepo.Update(id, professionalsMan,street,apartment);
                if (Update != null)
                {
                    return Update;
                }
                return NotFound();
            }
            [HttpDelete("{id}")]
            public ActionResult<AddressToClient> DeleteAdresses(int id)
            {
            AddressToClient delete = AddressToClientRepo.Delete(id);
                if (delete != null)
                {
                    return delete;
                }
                return NotFound();
            }
        }
}
