using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreAPI.Models;

namespace NetCoreAPI.Data
{
    public class NetCoreAPIContext : DbContext
    {
        public NetCoreAPIContext (DbContextOptions<NetCoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreAPI.Models.Usuario> Usuario { get; set; }
    }
}
