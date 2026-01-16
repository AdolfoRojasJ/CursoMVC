using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*  CREATE TABLE CARRITO(
    IdCarrito INT PRIMARY KEY AUTO_INCREMENT,
    IdCliente INT,
    IdProducto INT,
    Cantidad INT,
    FOREIGN KEY (IdCliente) REFERENCES CLIENTE(IdCliente),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
);
*/
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Cliente oCliente { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
