using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class VentaTicket
    {
        public int TicketNro { get; set; }
        public DateTime FechaHoraEnt { get; set; }
        public DateTime FechaHoraSal { get; set; }
        public int ClienteDNI { get; set; }
        public string AyN { get; set; }
        public string Telefono { get; set; }
        public int TVCodigo { get; set; }
        public string TipoVehiculo { get; set; }
        public decimal Tarifa { get; set; }
        public string Patente { get; set; }
        public int SectorCodigo { get; set; }
        public string SectorDescripcion { get; set; }
        public string SectorIdentificador { get; set; }
        public DateTime TiempoDisponible { get; set; }
        public string Duracion { get; set; }
        public decimal TarifaTicket { get; set; }
        public decimal Total { get; set; }
    }
}
