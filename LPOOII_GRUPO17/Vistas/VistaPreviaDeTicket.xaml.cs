﻿using System;
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
    /// Interaction logic for VistaPreviaDeTicket.xaml
    /// </summary>
    public partial class VistaPreviaDeTicket : Window
    {
        private Usuario usuario;
        public VistaPreviaDeTicket()
        {
            InitializeComponent();
            this.usuario = Menu.ObtenerUsuarioLogueado();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Recuperamos el ticket generado
            Ticket ticketGenerado = TrabajarTicket.RecuperarTicketGenerado();
            txbNroTicket.Text += ticketGenerado.TicketNro;
            txbFechaEnt.Text += ticketGenerado.FechaHoraEnt.ToString("dd/MM/yyyy HH:mm");
            //txbFechaSal.Text += ticketGenerado.FechaHoraSal.ToString("dd/MM/yyyy HH:mm");
            txbPatente.Text += ticketGenerado.Patente;
            //txbDuracion.Text += ticketGenerado.Duracion.ToString("F0") + " minutos ";
            txbTarifa.Text += "$" + ticketGenerado.Tarifa.ToString();
            txbTotal.Text += "S/D";
            //Recuperamos el cliente 
            Cliente clienteDoc = TrabajarClientes.TraerCliente(ticketGenerado.ClienteDNI);
            txbCliente.Text += clienteDoc.Apellido + ", " + clienteDoc.Nombre;
            //Recuperamos el Tipo de Vehiculo
            TipoVehiculo tvDoc = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(ticketGenerado.TVCodigo);
            txbTVDescripcion.Text += tvDoc.Descripcion;
            //Recuperamos el sector
            Sector sectorDoc = TrabajarSector.TraerSectorPorCodigo(ticketGenerado.SectorCodigo.ToString());
            txbSectorDescripcion.Text += sectorDoc.Descripcion + " " + sectorDoc.Identificador;
            //Usuario
            txbUsuario.Text += usuario.Apellido + " " + usuario.Nombre + " como " + usuario.Rol;
        }


    }
}
