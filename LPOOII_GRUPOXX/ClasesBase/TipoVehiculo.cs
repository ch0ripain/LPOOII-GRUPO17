using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TipoVehiculo
    {
        private int TVCodigo;
        private string Descripcion;
        private decimal Tarifa;

        public decimal tarifa
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public int tvCodigo
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }
    }
}
