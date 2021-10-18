using Microsoft.EntityFrameworkCore;
using RegistroDetalleModificado.DAL;
using RegistroDetalleModificado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalleModificado.BLL
{
    public class RolesBLL
    {
        public static int Total(Roles rol)
        {
            Contexto contexto = new Contexto();

            int total = 0;

            foreach (var item in rol.RolesDetalle)
            {
                var permiso = contexto.Permisos.Find(item.PermisoId);

                total += permiso.VecesAsignado;
            }
            return total;
        }
        public static bool Guardar(Roles rol)
        {
            if (!Existe(rol.RolId))
                return Insertar(rol);
            else
                return Modificar(rol);
        }
        private static bool Insertar(Roles rol)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                foreach (var item in rol.RolesDetalle)
                {
                    var permiso = contexto.Permisos.Find(item.PermisoId);

                    permiso.VecesAsignado += 1;
                }
                contexto.Roles.Add(rol);

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        private static bool Modificar(Roles rol)
        {
            int total = 0;

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                foreach (var item in rol.RolesDetalle)
                {
                    total += contexto.Permisos.Find(item.PermisoId).VecesAsignado;
                }

                contexto.Database.ExecuteSqlRaw($"Delete FROM RolesDetalle Where RolId={rol.RolId}");

                foreach (var item in rol.RolesDetalle)
                {
                    var permiso = contexto.Permisos.Find(item.PermisoId);

                    permiso.VecesAsignado += 1;

                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(rol).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                var rol = RolesBLL.Buscar(id);

                if (rol != null)
                {
                    foreach (var item in rol.RolesDetalle)
                    {
                        var permiso = contexto.Permisos.Find(item.PermisoId);

                        permiso.VecesAsignado -= 1;
                    }
                    contexto.Roles.Remove(rol);

                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Roles Buscar(int id)
        {
            Roles rol = new Roles();

            Contexto contexto = new Contexto();

            try
            {
                rol = contexto.Roles.Include(x => x.RolesDetalle).Where(x => x.RolId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return rol;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();

            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static List<Roles> GetList(Expression<Func<Roles, bool>> criterio)
        {
            List<Roles> Lista = new List<Roles>();

            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Roles.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static List<Roles> GetRoles()
        {
            List<Roles> Lista = new List<Roles>();

            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Roles.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
