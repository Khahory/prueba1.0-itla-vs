using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prueba1._0.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Planificacion> Planificacion { get; set; }
    }
}