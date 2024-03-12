using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlObject
{
    public class AddressToClient
    {
        public AddressToClient(string city,string nighbord)
        {
            this.City = city;
            this.Nighbord = nighbord;
        
        }
        public string City { get; set; }
        public string Nighbord { get; set; }

    }
}
