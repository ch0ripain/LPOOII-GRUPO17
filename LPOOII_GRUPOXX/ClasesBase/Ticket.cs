using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClasesBase
{
    public class Ticket
    {
        private int TicketNro;
        private DateTime FechaHoraEnt;
        private DateTime FechaHoraSal;
        private int ClienteDNI;
        private int TVCodigo;
        private string Patente;
        private int SectorCodigo;
        private double Duracion;
        private decimal Tarifa;
        private decimal Total;

        public decimal total
        {
            get { return Total; }
            set { Total = value; }
        }

        public decimal tarifa
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }

        public double duracion
        {
            get { return Duracion; }
            set { Duracion = value; }
        }

        public int sectorCodigo
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }

        public string patente
        {
            get { return Patente; }
            set { Patente = value; }
        }

        public int tvCodigo
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }

        public int clienteDNI
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }

        public DateTime fechaHoraSal
        {
            get { return FechaHoraSal; }
            set { FechaHoraSal = value; }
        }

        public DateTime fechaHoraEnt
        {
            get { return FechaHoraEnt; }
            set { FechaHoraEnt = value; }
        }

        public int ticketNro
        {
            get { return TicketNro; }
            set { TicketNro = value; }
        }
    }
}
