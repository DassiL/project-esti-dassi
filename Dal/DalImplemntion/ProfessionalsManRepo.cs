using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplemntion
{
    public class ProfessionalsManRepo : IProfessionalsManRepo
    {
        LibraryContext context;
        public ProfessionalsManRepo(LibraryContext context)
        {
            this.context = context;
        }

        public ProfessionalsMan AddProfessionalsMan(ProfessionalsMan professionalsMan)
        {
            context.ProfessionalsMen.Add(professionalsMan);
            context.SaveChanges();
            return professionalsMan;
        }

        public ProfessionalsMan DeleteProfessionalsMan(int id)
        {
            ProfessionalsMan remove =  context.ProfessionalsMen.FirstOrDefault(x=>x.Id == id);
            context.ProfessionalsMen.Remove(remove);
            context.SaveChanges();
            return remove;
        }

        public List<ProfessionalsMan> GetAllProfessionalsMan()
        {
            return context.ProfessionalsMen.ToList();
        }

        public ProfessionalsMan GetByIdProfessionalsMan(int id)
        {
            return context.ProfessionalsMen.FirstOrDefault(x=>x.Id == id);
        }
        public ProfessionalsMan UpdateProfessionalsMan(int id, ProfessionalsMan professionalsMan)
        {
            ProfessionalsMan n = context.ProfessionalsMen.FirstOrDefault(x => x.Id == id);
            n = professionalsMan;
            context.SaveChanges();
            return professionalsMan;
        }
    }
}
