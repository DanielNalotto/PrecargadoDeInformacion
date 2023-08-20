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
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                string query = "UPDATE usuario SET nombre = '" + usuario.Nombre + "', tel = " + usuario.Tel + ", mail = '" +
                usuario.Mail + "', calle = '" + usuario.Calle + "', nroPuerta = " + usuario.NroPuerta + " WHERE id = " + usuario.Id + ";";

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

    }
}
