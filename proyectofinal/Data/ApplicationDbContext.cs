using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proyectofinal.Models;

namespace proyectofinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<proyectofinal.Models.Proveedor> Proveedor { get; set; }
        public DbSet<proyectofinal.Models.usuario> usuario { get; set; }
        public DbSet<proyectofinal.Models.Pedido> Pedido { get; set; }
    }
}
