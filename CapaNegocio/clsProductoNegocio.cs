using Entidades;
using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class clsProductoNegocio : INegocio <clsProducto>
    {
        public IDatos<clsProducto> ProductoDatos { get; }

        public clsProductoNegocio(IDatos<clsProducto> _productosDatos)
        {
            ProductoDatos = _productosDatos;
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
            return ProductoDatos.getAll();
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

        public clsProducto save(clsProducto producto)
        {
            try
            {
                var cli = ProductoDatos.getByIdent(producto.codigo);
                if (cli != null)
                {
                    throw new EntityExistException("Producto");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return ProductoDatos.save(producto);
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
