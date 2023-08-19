using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using PrecargadoDeInformacion.Logica;
using MySqlConnector;

namespace PrecargadoDeInformacion.Persistencia
{
    internal class UsuarioDB
    {
        Usuario usuario;
        private string cadenaConexion = "Server=localhost;Database=precargadoinformacion;Uid=root;Pwd=;";



        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
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
            return usuarios;
        }


        /*
        public List<Usuario> obtenerUsuarios()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();

            string query = "SELECT id, nombre, tel, mail, calle, nroPuerta FROM usuario;";
            MySqlCommand command = new MySqlCommand (query, conexion);
            
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string nombre = reader.GetString("nombre");
                int tel = reader.GetInt32("tel");
                string mail = reader.GetString("mail");
                string calle = reader.GetString("calle");
                int nroPuerta = reader.GetInt32("nroPuerta");
                usuario = new Usuario(id, nombre, tel, mail, calle, nroPuerta);
                usuarios.Add(usuario);
            }
            return usuarios;
        }*/
    }
}
