using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Model;

namespace Vega.Persistance
{
    public class VegaDbContext: DbContext
    {
        //class is creating the database content
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }

    }
}
