using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE PRODUCTO(
    IdProducto INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(500),
    Descripcion VARCHAR(500),
    IdMarca INT,
    IdCategoria INT,
    Precio DECIMAL(10,2) DEFAULT 0,
    Stock INT,
    RutaImagen VARCHAR(100),
    NombreImagen VARCHAR(100),
    Activo BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT NOW(),
    FOREIGN KEY (IdMarca) REFERENCES MARCA(IdMarca),
    FOREIGN KEY (IdCategoria) REFERENCES CATEGORIA(IdCategoria)
);
*/
    public class Producto
    {
        public int IdProducto{ get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }

    }
}
