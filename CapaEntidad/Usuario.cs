using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE USUARIO(
    IdUsuario INT PRIMARY KEY AUTO_INCREMENT,
    Nombres VARCHAR(100),
    Apellidos VARCHAR(100),
    Correo VARCHAR(100),
    Clave VARCHAR(150),
    Restablecer BIT DEFAULT 1,
    Activo BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT NOW()
);
*/
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }
        public bool Activo { get; set; }

    }
}
