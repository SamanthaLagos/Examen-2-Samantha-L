using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUsuario.Entidades
{
    public class Detalle_Pedidos
    {
        public int IdDetalles_P { get; set; }
        public int IdPedidos { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }

        public Detalle_Pedidos()
        {

        }

        public Detalle_Pedidos(int idDetalles_P, int idPedidos, string codigoproducto, string descripcion, int cantidad, decimal precio, decimal total)
        {
            IdDetalles_P = idDetalles_P;
            IdPedidos = idPedidos;
            CodigoProducto = codigoproducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
