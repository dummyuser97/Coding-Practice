using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEFCore
{
    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

    }
}
