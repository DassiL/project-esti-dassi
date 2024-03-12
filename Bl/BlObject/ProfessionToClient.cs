using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlObject
{
    public class ProfessionToClient
    {
        public ProfessionToClient(int id, string type,ICollection<ProfessionalsManToclients> professionalsManToclients)
        {
            this.Type = type;
            this.Id = id;
            this.ProfessionalsMen = professionalsManToclients;
        }
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<ProfessionalsManToclients> ProfessionalsMen { get; set; } = new List<ProfessionalsManToclients>();
    }
}
