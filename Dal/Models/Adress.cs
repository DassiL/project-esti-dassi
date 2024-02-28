using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Adress
{
    public int Id { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string Apartment { get; set; }

    public virtual ICollection<ProfessionalsMan> ProfessionalsMen { get; set; } = new List<ProfessionalsMan>();
}
