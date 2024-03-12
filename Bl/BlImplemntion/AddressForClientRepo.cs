using Bl.BlApi;
using Bl.BlObject;
using Dal;
using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplemntion
{
    public class AddressForClientRepo : IRepo<AddressToClient>
    {
        DalManager dalManager;
        public AddressForClientRepo(DalManager dalManager)
        {
            this.dalManager = dalManager;
        }
        public Address Add(Address t)
        {
            dalManager.address.Add(t);
            return t;
        }
        public AddressToClient Add(AddressToClient t)
        {
            throw new NotImplementedException();
        }
        public AddressToClient Delete(int id)
        {
            Address a = dalManager.address.Delete(id);
            return new AddressToClient(a.City,a.Neighborhood);
        }
        public List<AddressToClient> GetAll()
        {
            List<Address> addressToClients = dalManager.address.GetAll();
            List<AddressToClient> ans = new List<AddressToClient>();
            for (int i = 0; i < addressToClients.Count; i++)
            {
                ans.Add(new AddressToClient(addressToClients[i].City, addressToClients[i].Street));
            }
            return ans;
        }

        public AddressToClient GetById(int id)
        {
            Address address = dalManager.address.GetById(id);
            return new AddressToClient(address.City, address.Street);
            
        }

        public AddressToClient Update(int id, AddressToClient t,string street,string apartment)
        {
            Address address = new Address();
            address.City = t.City;
            address.Neighborhood = t.Nighbord;
            address.Street = street;
            address.Apartment = apartment;
            dalManager.address.Update(id, address);
            return t;
        }


    }
}
