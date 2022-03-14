using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class EntityExistException : Exception
    {
        public EntityExistException(string entity) : base(string.Format("{0} ya existe en la base de datos.", entity))
        {

        }
    }
}
