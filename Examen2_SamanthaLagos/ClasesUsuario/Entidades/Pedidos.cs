using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUsuario.Entidades
{
    public class Pedidos
    {
        public int IdPedidos { get; set; }

        public string IdentidadClient { get; set; }

        public string Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Sub_Tot { get; set; }
        public decimal Isv { get; set; }

        public decimal Total { get; set; }

        public Pedidos()
        {

        }

        public Pedidos(int idPedidos, string identidadClient, string cliente, DateTime fecha, decimal sub_Tot, decimal isv, decimal total)
        {
            IdPedidos = idPedidos;
            IdentidadClient = identidadClient;
            Cliente = cliente;
            Fecha = fecha;
            Sub_Tot = sub_Tot;
            Isv = isv;
            Total = total;
        }
    }
}
