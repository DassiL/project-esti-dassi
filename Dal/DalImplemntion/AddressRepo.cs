﻿using Dal.DalApi;
using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplemntion
{
    public class AddressRepo : IRepo<Address>
    {
        LibraryContext context;
        public AddressRepo(LibraryContext context)
        {
            this.context = context;
        }

        public Address Add(Address t)
        {
            context.Addresses.Add(t);
            context.SaveChanges();
            return t;
        }


        public Address Delete(int id)
        {
            Address remove = context.Addresses.FirstOrDefault(x => x.Id == id);
            context.Addresses.Remove(remove);
            context.SaveChanges();
            return remove;
        }
        public List<Address> GetAll()
        {
            return context.Addresses.ToList();
        }

        public Address GetById(int id)
        {
            return context.Addresses.FirstOrDefault(x => x.Id == id);
        }

        public Address Update(int id, Address t)
        {
            Address n = context.Addresses.FirstOrDefault(x => x.Id == id);
            n = t;
            context.SaveChanges();
            return t;
        }
    }
}
