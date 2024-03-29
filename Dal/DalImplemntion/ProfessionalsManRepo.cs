﻿using Dal.DalApi;
using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplemntion
{
    public class ProfessionalsManRepo : IRepo<ProfessionalsMan>
    {
        LibraryContext context;
        public ProfessionalsManRepo(LibraryContext context)
        {
            this.context = context;
        }

        public ProfessionalsMan Add(ProfessionalsMan t)
        {
            context.ProfessionalsMen.Add(t);
            context.SaveChanges();
            return t;
        }

        public ProfessionalsMan Delete(int id)
        {
            ProfessionalsMan remove =  context.ProfessionalsMen.FirstOrDefault(x=>x.Id == id);
            context.ProfessionalsMen.Remove(remove);
            context.SaveChanges();
            return remove;
        }

        public List<ProfessionalsMan> GetAll()
        {
            return context.ProfessionalsMen.ToList();
        }

        public ProfessionalsMan GetById(int id)
        {
            return context.ProfessionalsMen.FirstOrDefault(x=>x.Id == id);
        }
        public ProfessionalsMan Update(int id, ProfessionalsMan professionalsMan)
        {
            ProfessionalsMan n = context.ProfessionalsMen.FirstOrDefault(x => x.Id == id);
            n = professionalsMan;
            context.SaveChanges();
            return professionalsMan;
        }

    }
}
