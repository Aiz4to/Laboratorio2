using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Interfaces
{
    public interface INegocio <entity>
    {
        entity save(entity producto);

        entity update(entity producto);

        bool delete(entity producto);

        List<entity> getAll();

        entity getById(int id);
    }
}
