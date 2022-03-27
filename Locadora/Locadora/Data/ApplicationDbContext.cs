using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locadora.Models;

namespace Locadora.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
