using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bl.BlObject
{
    public class ProfessionalsManToclients
    {
        public ProfessionalsManToclients(string firstName,string lastNmae, ProfessionToClient profession,int hourlyPrice, AddressToClient address,string email,string phon,string whatapp)
        {
            this.FirstName = firstName;
            this.LastName = lastNmae;
            this.profession = profession;
            this.HourlyPrice = hourlyPrice;
            this.Address = address;
            this.Email = email;
            this.Phon = phon;
            this.WhatsApp = whatapp;
        }
        public string WhatsApp { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ProfessionToClient profession { get; set; }

        public int? HourlyPrice { get; set; }

        public AddressToClient Address { get; set; }

        public string Email { get; set; }

        public string Phon { get; set; }
    }
}
