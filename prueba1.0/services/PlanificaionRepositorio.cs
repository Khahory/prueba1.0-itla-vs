using prueba1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba1._0.services
{
    public class PlanificaionRepositorio
    {
        public List<Planificacion> ObtenerDatos()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Planificacion.ToList();
            }
        }

        internal void Crear(Planificacion model)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Planificacion.Add(model);
                db.SaveChanges();
            }
        }
    }
}