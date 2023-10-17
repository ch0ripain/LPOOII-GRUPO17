using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Cliente : IDataErrorInfo
    {
        private int ClienteDNI;
        private string Apellido;
        private string Nombre;
        private string Telefono;

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public int clienteDNI
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;

                if (columnName == "ClienteDNI")
                {
                    if (ClienteDNI <= 0)
                        result = "El DNI debe ser mayor que 0";
                }
                else if (columnName == "Apellido")
                {
                    if (string.IsNullOrEmpty(Apellido))
                        result = "El apellido es obligatorio";
                }
                else if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                        result = "El nombre es obligatorio";
                }
                else if (columnName == "Telefono")
                {
                    if (string.IsNullOrEmpty(Telefono))
                        result = "El teléfono es obligatorio";
                }

                return result;
            }
        }
    }
}
