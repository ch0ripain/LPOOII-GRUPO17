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
    /// Interaction logic for VehiculosEnPlaya.xaml
    /// </summary>
    public partial class VehiculosEnPlaya : Window
    {
        private string sectorID;
        public VehiculosEnPlaya()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //btn7.Background = Brushes.Red;
            dcpZona2.Visibility = Visibility.Collapsed;
            dcpZona3.Visibility = Visibility.Collapsed;

            //Actualizar cada boton del stackpanel con verde si el campo "Habilitado" es True
            actualizarSectores();
        }

        private void ActualizarColoresBotones(StackPanel stackPanel)
        {
            foreach (var control in stackPanel.Children)
            {
                Button btn = control as Button;

                if (btn != null)
                {
                    int codigoSector = Convert.ToInt32(btn.Tag);
                        Sector sectorBuscado = TrabajarSector.TraerSectorPorCodigo(codigoSector.ToString());
                        if (sectorBuscado.Habilitado == true)
                        {
                            btn.Background = Brushes.LawnGreen;
                        }
                        if (sectorBuscado.Identificador == "Deshabilitado")
                        {
                            btn.Background = Brushes.DarkGray;
                        }
                        if (sectorBuscado.Habilitado == false)
                        {
                            btn.Background = Brushes.Red;
                        }
                }
            }
        }

        private void actualizarSectores()
        {
            ActualizarColoresBotones(stp1Z1);
            ActualizarColoresBotones(stp2Z1);

            ActualizarColoresBotones(stp1Z2);
            ActualizarColoresBotones(stp2Z2);
            ActualizarColoresBotones(stp3Z2);

            ActualizarColoresBotones(stp1Z3);
            ActualizarColoresBotones(stp2Z3);
        }

        private void btnSector_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                if (btn.Background.Equals(Brushes.LawnGreen))
                {
                    MessageBoxResult result = MessageBox.Show("Sector Disponible. Desea registrar una entrada?", "Registrar entrada del sector", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        // Aquí abres la ventana RegistrarEntrada
                        RegistrarEntrada oRegistrarEntrada = new RegistrarEntrada(sectorID);
                        oRegistrarEntrada.ShowDialog();
                        if (oRegistrarEntrada.sectorNoDisponible == true)
                        {
                            btn.Background = Brushes.Red;
                        }
                    }
                }
                else if (btn.Background.Equals(Brushes.Red))
                {
                    MessageBoxResult result = MessageBox.Show("Sector Ocupado. Desea registrar una salida?", "Registrar salida del sector", MessageBoxButton.YesNo, MessageBoxImage.Question);
                     if (result == MessageBoxResult.Yes)
                    {
                       // Acceder al valor del atributo Tag
                       object tagValue = btn.Tag;

                       // Puedes convertirlo a un tipo específico si es necesario
                       if (tagValue != null)
                       {
                           int sectorCodigo = Convert.ToInt32(tagValue);
                           Ticket ticketEntrada = TrabajarTicket.RecuperarTicketPorSectorCodigo(sectorCodigo);
                           RegistrarSalida oRegistrarSalida = new RegistrarSalida(ticketEntrada, sectorCodigo.ToString());
                           oRegistrarSalida.ShowDialog();
                           if (oRegistrarSalida.sectorDisponible == true)
                           {
                               btn.Background = Brushes.LawnGreen;
                           }
                       } 
                    }
                }
                else if (btn.Background.Equals(Brushes.DarkGray))
                {
                    MessageBox.Show("Sector deshabilitado!","Información del sector", MessageBoxButton.OK , MessageBoxImage.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmbZona_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtén el valor seleccionado del ComboBox
            string cmbValor = cmbZona.SelectedValue.ToString();

            // Oculta todos los DockPanels
            //dcpZona1.Visibility = Visibility.Collapsed;
            dcpZona2.Visibility = Visibility.Collapsed;
            dcpZona3.Visibility = Visibility.Collapsed;

            // Muestra el DockPanel correspondiente a la zona seleccionada
            if (cmbValor == "1")
            {
                dcpZona1.Visibility = Visibility.Visible;
            }
            else if (cmbValor == "2")
            {
                dcpZona2.Visibility = Visibility.Visible;
                dcpZona3.Visibility = Visibility.Collapsed;
                dcpZona1.Visibility = Visibility.Collapsed;
            }
            else if (cmbValor == "3")
            {
                dcpZona3.Visibility = Visibility.Visible;
                dcpZona1.Visibility = Visibility.Collapsed;
                dcpZona2.Visibility = Visibility.Collapsed;
            }
        }

        private void btnSector_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
    
           if (btn != null)
             {
                // Acceder al valor del atributo Tag
               object tagValue = btn.Tag;

               // Puedes convertirlo a un tipo específico si es necesario
               if (tagValue != null)
               {
                   int sectorCodigo = Convert.ToInt32(tagValue);
                   ToolTip toolTip = new ToolTip();

               if (btn.Background.Equals(Brushes.LawnGreen)) //Mostrar cuanto tiempo lleva disponible
               {
                   Sector sectorBuscado = new Sector();
                   sectorBuscado = TrabajarSector.TraerSectorPorCodigo(sectorCodigo.ToString());
                   sectorID = sectorBuscado.SectorCodigo.ToString();

                   DateTime tiempoDisponible = sectorBuscado.TiempoDisponible;
                   TimeSpan tiempoTranscurrido = DateTime.Now - tiempoDisponible;

                   string formato = "Disponible hace ";

                   if (tiempoTranscurrido.Days > 0)
                   {
                       formato += tiempoTranscurrido.Days + " día" + (tiempoTranscurrido.Days > 1 ? "s, " : ", ");
                   }

                   if (tiempoTranscurrido.Hours > 0)
                   {
                       formato += tiempoTranscurrido.Hours + " hora" + (tiempoTranscurrido.Hours > 1 ? "s, " : ", ");
                   }

                   if (tiempoTranscurrido.Minutes > 0)
                   {
                       formato += tiempoTranscurrido.Minutes + " minuto" + (tiempoTranscurrido.Minutes > 1 ? "s " : " y ");
                   }

                   if (tiempoTranscurrido.Seconds > 0)
                   {
                       formato += tiempoTranscurrido.Seconds + " segundo" + (tiempoTranscurrido.Seconds > 1 ? "s" : "");
                   }

                   // Asigna la cadena formateada al Tooltip
                   toolTip.Content = formato;
                   btn.ToolTip = toolTip;
               }
               else if (btn.Background.Equals(Brushes.DarkGray)) // Mostrar "Sector no disponible"
               {
                   toolTip.Content = "Sector no disponible!";
                   btn.ToolTip = toolTip;
               }
               else if (btn.Background.Equals(Brushes.Red)) // Mostrar datos del tiempo que lleva ocupado ese sector, el tipo de vehículo, el monto que se debería pagar, etc.
               {
                   Ticket ticketBuscado = TrabajarTicket.RecuperarTicketPorSectorCodigo(sectorCodigo);

                   DateTime tiempoDisponible = ticketBuscado.FechaHoraEnt;
                   TimeSpan tiempoTranscurrido = DateTime.Now - tiempoDisponible;

                   string formato = "Ocupado hace ";

                   if (tiempoTranscurrido.Days > 0)
                   {
                       formato += tiempoTranscurrido.Days + " día" + (tiempoTranscurrido.Days > 1 ? "s, " : ", ");
                   }

                   if (tiempoTranscurrido.Hours > 0)
                   {
                       formato += tiempoTranscurrido.Hours + " hora" + (tiempoTranscurrido.Hours > 1 ? "s, " : ", ");
                   }

                   if (tiempoTranscurrido.Minutes > 0)
                   {
                       formato += tiempoTranscurrido.Minutes + " minuto" + (tiempoTranscurrido.Minutes > 1 ? "s " : " y ");
                   }

                   if (tiempoTranscurrido.Seconds> 0)
                   {
                       formato += tiempoTranscurrido.Seconds + " segundo" + (tiempoTranscurrido.Seconds > 1 ? "s" : "");
                   }

                   Cliente clienteBuscado = TrabajarClientes.TraerCliente(ticketBuscado.ClienteDNI);
                   TipoVehiculo vehiculoBuscado = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(ticketBuscado.TVCodigo);
                   //Calcular el total -> (Duracion/15) / 4 * Tarifa
                   decimal monto = Math.Round((((decimal)tiempoTranscurrido.TotalMinutes / 15) / 4) * ticketBuscado.Tarifa, 2);

                   toolTip.Content = formato + "\nCliente: " + clienteBuscado.Nombre + " " + clienteBuscado.Apellido + "\nTipo de vehiculo: " + vehiculoBuscado.Descripcion + "\nPatente: " + ticketBuscado.Patente + "\nTarifa/hora: $" + ticketBuscado.Tarifa + "\nMonto a pagar: $" + monto;
                   btn.ToolTip = toolTip;
               }
                

                    
               }
           }
       }

        private void btnListarVentas_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeVentas oListadoDeVentas = new ListadoDeVentas();
            oListadoDeVentas.Show();
        }

        private void btnVerSO_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeSectoresOcupados oListadoSO = new ListadoDeSectoresOcupados();
            oListadoSO.Show();
        }
    }
}
