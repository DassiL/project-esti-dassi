using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class ProfessionalsMan
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int IdType { get; set; }

    public int? HourlyPrice { get; set; }

    public int IdAdress { get; set; }

    public string Email { get; set; }

    public string Phon { get; set; }

    public virtual Adress IdAdressNavigation { get; set; }

    public virtual Profession IdTypeNavigation { get; set; }

    public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
}
