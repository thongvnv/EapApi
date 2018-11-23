using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EAPApi.Models
{
    public class EAPApiContext : DbContext
    {
        public EAPApiContext (DbContextOptions<EAPApiContext> options)
            : base(options)
        {
        }

        public DbSet<EAPApi.Models.Employee> Employee { get; set; }
    }
}
