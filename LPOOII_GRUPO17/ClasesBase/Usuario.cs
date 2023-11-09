using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Usuario : INotifyPropertyChanged
    {
        private string userName;
        private string password;
        private string apellido;
        private string nombre;
        private string rol;

        public string UserName
        {
            get { return userName; }
            set 
            { 
            userName = value;
            Notificador(userName);
            }
        }
       
        public string Password
        {
            get { return password; }
            set { 
                password = value;
                Notificador(password);
                }
        }
        
        public string Apellido
        {
            get { return apellido; }
            set { 
                apellido = value;
                Notificador(apellido);
                }
        }
       
        public string Nombre
        {
            get { return nombre; }
            set { 
                nombre = value;
                Notificador(nombre);
                }
        }
        
        public string Rol
        {
            get { return rol; }
            set { 
                rol = value;
                Notificador(rol);
                }
        }

        public Usuario() { }

        public Usuario(string pUserName, string pPassword, string pApellido, string pNombre, string pRol)
        {
            UserName = pUserName;
            Password = pPassword;
            Apellido = pApellido;
            Nombre = pNombre;
            Rol = pRol;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notificador(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
