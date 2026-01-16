using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /* CREATE TABLE DETALLE_VENTA(
    IdDetalleVenta INT PRIMARY KEY AUTO_INCREMENT,
    IdVenta INT,
    IdProducto INT,
    Cantidad INT,
    Total DECIMAL(10,2),
    FOREIGN KEY (IdVenta) REFERENCES VENTA(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)  
);

*/
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public string IdVenta { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }

    }
}
