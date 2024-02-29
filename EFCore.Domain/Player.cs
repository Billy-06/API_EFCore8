using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain;
public class Player : BaseDomainClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
}

