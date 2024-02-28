using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace project.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class professionalsManController : ControllerBase
    {
        IProfessionalsManRepo professionalsManRepo;
        public professionalsManController( IProfessionalsManRepo professionalsManRepo)
        {
            this.professionalsManRepo = professionalsManRepo;
        }
        [HttpGet]
        public ActionResult<List<ProfessionalsMan>> GetAllProfessionalsMan()
        {
            List<ProfessionalsMan> get = professionalsManRepo.GetAllProfessionalsMan();
            if (get != null)
            {
                return get;
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<ProfessionalsMan> GetByIdProfessionalsMan(int id)
        {
            ProfessionalsMan getbyid = professionalsManRepo.GetByIdProfessionalsMan(id);
            if (getbyid != null)
            {
                return getbyid;
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<ProfessionalsMan> AddProfessionalsMan(ProfessionalsMan professionalsMan)
        {
            ProfessionalsMan add = professionalsManRepo.AddProfessionalsMan(professionalsMan);
            if (add != null)
            {
                return add;
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public ActionResult<ProfessionalsMan> UpDateProfessionalsMan(int id, ProfessionalsMan professionalsMan)
        {
            ProfessionalsMan Update =  professionalsManRepo.UpdateProfessionalsMan(id, professionalsMan);
            if (Update != null)
            {
                return Update;
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public ActionResult<ProfessionalsMan> DeleteProfessionalsMan(int id)
        {
            ProfessionalsMan delete = professionalsManRepo.DeleteProfessionalsMan(id);
            if (delete != null)
            {
                return delete;
            }
            return NotFound();
        }
    }
}
