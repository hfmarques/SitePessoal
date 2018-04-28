using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SitePessoal.Persistence
{
    public class SitePessoalDbContext : DbContext
    {
        public SitePessoalDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
