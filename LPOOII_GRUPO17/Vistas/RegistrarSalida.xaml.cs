using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for RegistrarSalida.xaml
    /// </summary>
    public partial class RegistrarSalida : Window
    {
        private string sectorID;
        public bool sectorDisponible { get; set; }
        private Ticket ticketSalida;
        public RegistrarSalida()
        {
            InitializeComponent();
        }

        public RegistrarSalida(Ticket ticketEntrada, string sectorId)
        {
            InitializeComponent();
            ticketSalida = ticketEntrada;
            sectorID = sectorId;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Recuperar datos del ticket
            txtClienteDNI.Text = ticketSalida.ClienteDNI.ToString();
            //Recuperamos el Tipo de Vehiculo
            TipoVehiculo tvDoc = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(ticketSalida.TVCodigo);
            txtTV.Text = tvDoc.Descripcion;
            txtPatente.Text = ticketSalida.Patente;
            //Recuperamos el sector
            Sector sectorDoc = TrabajarSector.TraerSectorPorCodigo(ticketSalida.SectorCodigo.ToString());
            txtSector.Text = sectorDoc.Descripcion + " " + sectorDoc.Identificador;
            txtTarifa.Text = "$" + ticketSalida.Tarifa.ToString();
            ticketSalida.FechaHoraSal = DateTime.Now;
            txtFechaSal.Text = ticketSalida.FechaHoraSal.ToString("dd/MM/yyyy HH:mm");
            TimeSpan duracion = ticketSalida.FechaHoraSal - sectorDoc.TiempoDisponible;

            string formato = "";

            if (duracion.Days > 0)
            {
                formato += duracion.Days + " día" + (duracion.Days > 1 ? "s, " : ", ");
            }

            if (duracion.Hours > 0)
            {
                formato += duracion.Hours + " hora" + (duracion.Hours > 1 ? "s, " : ", ");
            }

            if (duracion.Minutes > 0)
            {
                formato += duracion.Minutes + " minuto" + (duracion.Minutes > 1 ? "s, " : " y ");
            }

            if (duracion.Seconds > 0)
            {
                formato += duracion.Seconds + " segundo" + (duracion.Seconds > 1 ? "s" : "");
            }

            txtDuracion.Text = formato;
            ticketSalida.Duracion = (decimal)duracion.TotalMinutes;

            //Calcular el total -> (Duracion/15) / 4 * Tarifa
            ticketSalida.Total = Math.Round((((decimal)duracion.TotalMinutes / 15) / 4) * ticketSalida.Tarifa, 2);
            txtTotal.Text = "$"+ticketSalida.Total.ToString("N2");
            
        }

        private void btnRegistrarSalida_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea registrar la salida de este Ticket?" + "\nFecha y hora de entrada: " + ticketSalida.FechaHoraEnt + "\nFecha y hora de salida: " + ticketSalida.FechaHoraSal + "\nDNI del cliente: " + ticketSalida.ClienteDNI + "\nTipo de vehículo: " + txtTV.Text + "\nPatente: " + ticketSalida.Patente + "\nLugar: " + txtSector.Text + "\nTarifa: $" + ticketSalida.Tarifa + "\nDuración: " + Math.Floor(ticketSalida.Duracion) + " minutos" + "\nTotal: $" + ticketSalida.Total, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            this.sectorDisponible = false;
            if (result == MessageBoxResult.Yes)
            {
                //Cambiar el color del sector a rojo y actualizo el estado y la fecha del sector
                this.sectorDisponible = true;
                TrabajarSector.ModificarEstadoSectorDisponible(ticketSalida.SectorCodigo, ticketSalida.FechaHoraSal);
                //Actualizo los datos del ticket
                TrabajarTicket.ActualizarTicket(ticketSalida.FechaHoraSal, ticketSalida.Duracion, ticketSalida.Total, ticketSalida.TicketNro);
                this.Close();
                VistaPreviaDeTicketSalida vpdts = new VistaPreviaDeTicketSalida(ticketSalida.SectorCodigo);
                vpdts.Show();
            }
        }

    }
}
