using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sector
    {
        private int sectorCodigo;
        private string descripcion;
        private string identificador;
        private bool habilitado;

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        public string Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int SectorCodigo
        {
            get { return sectorCodigo; }
            set { sectorCodigo = value; }
        }
    }
}
