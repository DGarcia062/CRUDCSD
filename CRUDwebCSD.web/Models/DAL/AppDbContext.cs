using CRUDwebCSD.web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwebCSD.web.Models.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } //Tablas en la base de datos
        public DbSet<CargoCliente> CargosCliente { get; set; } //Tablas en la base de datos
    }
}
