using ClasesUsuario.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUsuario.Acceso
{
    public class UsuarioDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=12345678;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string nombreUsuario, string contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("Contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NombreUsuario = reader[0].ToString();
                    user.Contraseña = reader[1].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }
    }
}
