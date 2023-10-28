using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_PA2.Models;

namespace ASP_NET_INMN2_PA2.Data
{
    public class ASP_NET_INMN2_PA2Context : DbContext
    {
        public ASP_NET_INMN2_PA2Context (DbContextOptions<ASP_NET_INMN2_PA2Context> options)
            : base(options)
        {
        }

        public DbSet<ASP_NET_INMN2_PA2.Models.Miasto> Miasta { get; set; } = default!;
    }
}
