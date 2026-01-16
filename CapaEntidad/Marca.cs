using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE MARCA(
    IdMarca INT PRIMARY KEY AUTO_INCREMENT,
    Descripcion VARCHAR(100),
    Activo BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT NOW()
);
*/
    public class Marca
    {
        public int IdMarca{ get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

    }
}
