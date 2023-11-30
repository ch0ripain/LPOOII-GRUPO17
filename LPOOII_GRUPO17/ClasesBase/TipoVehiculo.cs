using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class TipoVehiculo : IDataErrorInfo
    {
        private int tvCodigo;
        private string descripcion;
        private decimal tarifa;
        private string imagen;

        public decimal Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int TVCodigo
        {
            get { return tvCodigo; }
            set { tvCodigo = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
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
                    case "TVCodigo":
                        msg_error = ValidarTVCodigo();
                        break;
                    case "Descripcion":
                        msg_error = ValidarDescripcion();
                        break;
                    case "Tarifa":
                        msg_error = ValidarTarifa();
                        break;
                    case "Imagen":
                        msg_error = ValidarImagen();
                        break;
                }

                return msg_error;
            }
        }

        private string ValidarTVCodigo()
        {
            if (TVCodigo <= 0)
            {
                return "El valor del campo Código debe ser mayor a 0.";
            }
            return null;
        }

        private string ValidarDescripcion()
        {
            if (string.IsNullOrEmpty(Descripcion))
            {
                return "El valor del campo Descripción es obligatorio.";
            }
            return null;
        }

        private string ValidarTarifa()
        {
            if (Tarifa < 0)
            {
                return "El valor del campo Tarifa no puede ser negativo.";
            }
            return null;
        }

        private string ValidarImagen()
        {
            if (string.IsNullOrEmpty(Descripcion))
            {
                return "El valor del campo Imagen es obligatorio.";
            }
            return null;
        }
    }
}
