using Dal.DalImplemntion;
using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public ProfessionalsManRepo professionalsMan { get; set; }
        public ProfessionRepo profession { get; set; }
        public AddressRepo address { get; set; }
        public ReferenceRepo reference { get; set; }

        public DalManager() {
            LibraryContext context = new LibraryContext();
            professionalsMan = new ProfessionalsManRepo(context);
            profession = new ProfessionRepo(context);
            address = new AddressRepo(context);
            reference = new ReferenceRepo(context);
        }
    }
}
