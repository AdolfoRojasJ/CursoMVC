using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE CATEGORIA(
    IdCategoria INT PRIMARY KEY AUTO_INCREMENT,
    Descripcion VARCHAR(100),
    Activo BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT NOW()
);*/
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

    }
}
