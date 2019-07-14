using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Philson.Models;

namespace Philson.Models
{
    public class PhilsonContext : DbContext
    {
        public PhilsonContext (DbContextOptions<PhilsonContext> options)
            : base(options)
        {
        }

        public DbSet<Philson.Models.SuppliedInterloan> SuppliedInterloan { get; set; }

        public DbSet<Philson.Models.ReceivedInterloan> ReceivedInterloan { get; set; }
    }
}
