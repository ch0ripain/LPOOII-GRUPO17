using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClasesBase
{
    public class Ticket
    {
        private int ticketNro;
        private DateTime fechaHoraEnt;
        private DateTime fechaHoraSal;
        private int clienteDNI;
        private int tvCodigo;
        private string patente;
        private int sectorCodigo;
        private decimal duracion;
        private decimal tarifa;
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        public decimal Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int SectorCodigo
        {
            get { return sectorCodigo; }
            set { sectorCodigo = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public int TVCodigo
        {
            get { return tvCodigo; }
            set { tvCodigo = value; }
        }

        public int ClienteDNI
        {
            get { return clienteDNI; }
            set { clienteDNI = value; }
        }

        public DateTime FechaHoraSal
        {
            get { return fechaHoraSal; }
            set { fechaHoraSal = value; }
        }

        public DateTime FechaHoraEnt
        {
            get { return fechaHoraEnt; }
            set { fechaHoraEnt = value; }
        }

        public int TicketNro
        {
            get { return ticketNro; }
            set { ticketNro = value; }
        }
    }
}
