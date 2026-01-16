using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE CLIENTE(
    IdCliente INT PRIMARY KEY AUTO_INCREMENT,
    Nombres VARCHAR(100),
    Apellidos VARCHAR(100),
    Correo VARCHAR(100),
    Clave VARCHAR(150),
    Restablecer BIT DEFAULT 0,
    FechaRegistro DATETIME DEFAULT NOW()
);
*/
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }

    }
}
