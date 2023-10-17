using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private string UserName;
        private string Password;
        private string Apellido;
        private string Nombre;
        private string Rol;

        public string userName
        {
            get { return UserName; }
            set { UserName = value; }
        }
       
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
       
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        
        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }
    }
}
