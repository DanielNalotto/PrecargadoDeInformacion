using PrecargadoDeInformacion.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PrecargadoDeInformacion.Persistencia;

namespace PrecargadoDeInformacion.Logica
{
    internal class Usuario
    {
        UsuarioDB db = new UsuarioDB();
        private string nombre, mail, calle;
        private int id, tel, nroPuerta;

        /// -------------------------- CONSTRUCTORES --------------------------------
        public Usuario() {}

        public Usuario(int id, string nombre, int tel, string mail, string calle, int nroPuerta)
        {
            this.id = id;
            this.nombre = nombre;
            this.tel = tel;
            this.mail = mail;
            this.calle = calle;
            this.nroPuerta = nroPuerta;
        }


        /// -------------------------- GETTERS --------------------------------
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public int NroPuerta
        {
            get { return nroPuerta; }
            set { nroPuerta = value; }
        }


        /// -------------------------- VALIDACION DE DATOS --------------------------------
        public bool validarNombre(string nombre)
        {
            return !String.IsNullOrEmpty(nombre);
        }

        public bool validarTel(string tel)
        {
            try
            {
                Int32.Parse(tel);
                return tel.Length == 8;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
       
        public bool validarMail(string mail)
        {
            if (Regex.IsMatch(mail, "[.@_a-z0-9-]"))
                return true;
            else
                return false;
        }
       
        public bool validarNroPuerta(string nroPuerta)
        {
            try
            {
                Int32.Parse(nroPuerta);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool validarCalle(string calle)
        {
            return !String.IsNullOrEmpty(calle);
        }
    
    
    
        public List<Usuario> obtenerUsuarios()
        {
            return db.obtenerUsuarios();
        }




    }
}
