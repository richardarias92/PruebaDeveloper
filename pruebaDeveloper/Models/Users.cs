using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace pruebaDeveloper.Models
{
    public class Users
    {
        public int Idusuario { get; set; }
        public string C_client { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int NCelular { get; set; }
        public string Tcontact { get; set; }

        public Users()//Constructor vacio
        {

        }

        public Users(int Idusuario, string C_client, string Usuario, string Nombre, string Cargo, int Telefono, string Email, int NCelular, string Tcontact)
        {
            this.Idusuario = Idusuario;
            this.C_client = C_client;
            this.Usuario = Usuario;
            this.Nombre = Nombre;
            this.Cargo = Cargo;
            this.Telefono = Telefono;
            this.Email = Email;
            this.NCelular = NCelular;
            this.Tcontact = Tcontact;

        }

        //Metodo de la clase
        public List<Users> ListadoDeUsuarios()
        {
            List<Users> Listado = new List<Users>();

            Users Carlos = new Users(1, "xmxwebdemo2", "XMXWAM014", "Carlos", "It sistems", 323343456, "carlos.arias@intcomex.com", 43432342, "Contacto Comercial");
            Listado.Add(Carlos);
            Users Juan = new Users(2, "xmxwebdemo2", "XMXWAME04", "Juan", "IT Especialist", 323346559, "Juan.arias@intcomex.com", 08632342, "Representante legal");
            Listado.Add(Juan);
            return Listado;
        }
    }


}