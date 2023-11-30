using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Cliente : IDataErrorInfo
    {
        private int clienteDNI;
        private string apellido;
        private string nombre;
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int ClienteDNI
        {
            get { return clienteDNI; }
            set { clienteDNI = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string msg_error = null;

                switch (columnName)
                { 
                    case "ClienteDNI":
                        msg_error = validar_ClienteDNI();
                        break;
                    case "Apellido":
                        msg_error = validar_Apellido();
                        break;
                    case "Nombre":
                        msg_error = validar_Nombre();
                        break;
                    case "Telefono":
                        msg_error = validar_Telefono();
                        break;
                }

                return msg_error;
                
            }
        }

        private string validar_ClienteDNI()
        {
            if (String.IsNullOrEmpty(ClienteDNI.ToString()))
            {
                return "El valor del campo DNI es obligatorio.";
            }
            else if (ClienteDNI <= 0)
            {
                return "El valor del campo DNI debe ser mayor a 0.";
            }
            return null;
        }

        private string validar_Apellido()
        {
            if (String.IsNullOrEmpty(Apellido))
            {
                return "El valor del campo Apellido es obligatorio.";
            }
            return null;
        }

        private string validar_Nombre()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                return "El valor del campo Nombre es obligatorio.";
            }
            return null;
        }

        private string validar_Telefono()
        {
            if (String.IsNullOrEmpty(Telefono))
            {
                return "El valor del campo Telefono es obligatorio.";
            }
            return null;
        }

    }
}
