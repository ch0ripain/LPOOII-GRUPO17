using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sector
    {
        private int SectorCodigo;
        private string Descripcion;
        private string Identificador;
        private bool Habilitado;

        public bool habilitado
        {
            get { return Habilitado; }
            set { Habilitado = value; }
        }

        public string identificador
        {
            get { return Identificador; }
            set { Identificador = value; }
        }

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public int sectorCodigo
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }
    }
}
