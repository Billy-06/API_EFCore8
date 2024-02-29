using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain;

public class Team : BaseDomainClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public int CoachId { get; set; }
    public Coach Coach { get; set; }
    public List<Player> Players { get; set; }
}

