using Microsoft.EntityFrameworkCore;
using RegistroDetalleModificado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalleModificado.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\RegistroDetalleModificado.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1,
                Nombre = "Permiso para Vacacionar",
                Descripcion = "Permiso otorgado para que el trabajador pueda descansar",
                VecesAsignado = 0
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 2,
                Nombre = "Permiso de Emergencia",
                Descripcion = "Permiso otorgado para que el trabajador pueda salir por cualquier inconveniente",
                VecesAsignado = 0
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3,
                Nombre = "Permiso de Salud",
                Descripcion = "Permiso otorgado para que el trabajador salga de licencia hasta que se recupere",
                VecesAsignado = 0
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 4,
                Nombre = "Permiso por Fallecimiento",
                Descripcion = "Permiso otorgado al trabajador por la muerte de un familiar",
                VecesAsignado = 0
            });
        }
    }
}
