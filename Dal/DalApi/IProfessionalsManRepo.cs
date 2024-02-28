using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IProfessionalsManRepo
    {
        List<ProfessionalsMan> GetAllProfessionalsMan();
        ProfessionalsMan GetByIdProfessionalsMan(int id);
        ProfessionalsMan AddProfessionalsMan(ProfessionalsMan professionalsMan);
        ProfessionalsMan UpdateProfessionalsMan(int id,ProfessionalsMan professionalsMan);
        ProfessionalsMan DeleteProfessionalsMan(int id);
    }
}
