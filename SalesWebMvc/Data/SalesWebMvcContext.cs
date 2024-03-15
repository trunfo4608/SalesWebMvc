using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Models;

    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

    public DbSet<Departament> Departament { get; set; }
    public DbSet<SalesRecord> SalesRecords { get; set; }
    public DbSet<Seller> Sellers { get; set; }

}
