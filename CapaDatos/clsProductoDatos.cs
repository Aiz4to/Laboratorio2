using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class clsProductoDatos : IDatos <clsProducto>
    {
        List<clsProducto> lista;

        public clsProductoDatos()
        {
            this.lista = new List<clsProducto>();
        }

        public bool delete(clsProducto producto)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<clsProducto> getAll()
        {
            try
            {
                return this.lista.Where(x => x.estado == true).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public clsProducto getById(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public clsProducto getByIdent(string id)
        {
            try
            {
                return lista.Where(x => x.codigo.Trim().Equals(id.Trim())).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public clsProducto save(clsProducto producto)
        {
            try
            {
                producto.id = getNextId();
                this.lista.Add(producto);
                return producto;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        private int getNextId()
        {
            return lista.Count() + 1;
        }

        public clsProducto update(clsProducto producto)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
