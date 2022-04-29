using ClasesUsuario.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClasesUsuario.Acceso
{
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=12345678;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertPedido(Pedidos pedidos)
        {
            int IdPedidos = 0;
            try
            {
                string sql = "INSERT INTO pedidos (IdentidadClient, Cliente, Fecha, Sub_Tot, Impuesto, Total) VALUES (@IdentidadClient, @Cliente, @Fecha, @Sub_Tot, @Impuesto, @Total ) SELECT LAST_INSERT_ID();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdentidadClient", pedidos.IdentidadClient);
                cmd.Parameters.AddWithValue("@Cliente", pedidos.Cliente);
                cmd.Parameters.AddWithValue("@Fecha", pedidos.Fecha);
                cmd.Parameters.AddWithValue("@Sub_Tot", pedidos.Sub_Tot);
                cmd.Parameters.AddWithValue("@Impuesto", pedidos.Isv);
                cmd.Parameters.AddWithValue("@Total", pedidos.Total);

                IdPedidos = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return IdPedidos;

        }
        public bool InsertDetalle_P(Detalle_Pedidos detalle_Ped)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detalles_pedidos VALUES (@IdPedidos, @Codigo, @Descripcion, @Cantidad, @Precio, @Total );";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdPedidos", detalle_Ped.IdPedidos);
                cmd.Parameters.AddWithValue("@Codigo", detalle_Ped.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", detalle_Ped.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", detalle_Ped.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detalle_Ped.Precio);
                cmd.Parameters.AddWithValue("@Total", detalle_Ped.Total);
                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }
    }
}
