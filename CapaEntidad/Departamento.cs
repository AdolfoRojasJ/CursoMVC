using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE DEPARTAMENTO (
    IdProvincia VARCHAR(4),
    Descripcion VARCHAR(45),
    IdDepartamento VARCHAR(2)
);

*/
    public class Departamento
    {
        public string Descripcion { get; set; }
        public string IdDepartamento { get; set; }
    }
}
