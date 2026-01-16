using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /* CREATE TABLE VENTA(
    IdVenta INT PRIMARY KEY AUTO_INCREMENT,
    IdCliente INT,
    TotalProducto INT,
    MontoTotal DECIMAL(10,2),
    Contacto VARCHAR(50),
    IdDistrito VARCHAR(10),
    Telefono VARCHAR(50),
    Direccion VARCHAR (500),
    IdTransaccion VARCHAR (50),
    FechaVenta DATETIME DEFAULT NOW(),
    FOREIGN KEY (IdCliente) REFERENCES CLIENTE(IdCliente)
);
*/
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaTexto { get; set; }
        public string IdTransaccion { get; set; }
        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
