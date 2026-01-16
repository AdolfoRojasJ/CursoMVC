using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE DISTRITO (
    IdDistrito VARCHAR(6),
    Descripcion VARCHAR(45),
    IdProvincia VARCHAR(4),
    IdDepartamento VARCHAR(2)
);

*/
    public class Distrito
    {
        public string IdDistrito { get; set; }
        public string Descripcion { get; set; }
    }
}
