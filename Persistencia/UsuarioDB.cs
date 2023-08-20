using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using PrecargadoDeInformacion.Logica;
using MySqlConnector;
using Org.BouncyCastle.Utilities.Collections;
using Microsoft.VisualBasic;

namespace PrecargadoDeInformacion.Persistencia
{
    internal class UsuarioDB
    {
        Usuario usuario;
        private string cadenaConexion = "Server=localhost;Database=precargadoinformacion;Uid=root;Pwd=;";

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();

            string query = "SELECT id, nombre, tel, mail, calle, nroPuerta FROM usuario;";
            MySqlCommand command = new MySqlCommand(query, conexion);

            using MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Usuario usuario = new Usuario
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Tel = reader.GetInt32("tel"),
                    Mail = reader.GetString("mail"),
                    Calle = reader.GetString("calle"),
                    NroPuerta = reader.GetInt32("nroPuerta")
                };

                usuarios.Add(usuario);
            }
            conexion.Close();
            return usuarios;
        }

        public bool ingresarUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                string query = "INSERT INTO usuario(nombre, tel, mail, calle, nroPuerta) VALUES('" +
                    usuario.Nombre + "', " + usuario.Tel + ", '" + usuario.Mail + "', '" + usuario.Calle + "', " + usuario.NroPuerta + ");";

                MySqlCommand command = new MySqlCommand(query, conexion);
                command.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool modificarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "UPDATE usuario SET nombre=@nombre, tel=@tel, mail=@mail, calle=@calle, nroPuerta=@nroPuerta WHERE id=@id;";

                    MySqlCommand command = new MySqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@tel", usuario.Tel);
                    command.Parameters.AddWithValue("@mail", usuario.Mail);
                    command.Parameters.AddWithValue("@calle", usuario.Calle);
                    command.Parameters.AddWithValue("@nroPuerta", usuario.NroPuerta);
                    command.Parameters.AddWithValue("@id", usuario.Id);

                    string mensaje = usuario.Nombre + "\n" + usuario.Tel.ToString() + "\n" + usuario.Mail + "\n" + usuario.Calle + "\n" + usuario.NroPuerta.ToString() + "\n" + usuario.Id.ToString();

                    int filasAfectadas = command.ExecuteNonQuery();

                    conexion.Close();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool borrarUsuario(int id)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM usuario WHERE id=@id;";

                    MySqlCommand command = new MySqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAfected = command.ExecuteNonQuery();
                    return rowsAfected > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
