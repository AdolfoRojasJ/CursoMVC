using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE PROVINCIA (
    IdProvincia VARCHAR(4),
    Descripcion VARCHAR(45),
    IdDepartamento VARCHAR(2)
);
*/
    public class Provincia
    {
        public string IdProvincia { get; set; }
        public string Descripcion { get; set; }
    }
}
