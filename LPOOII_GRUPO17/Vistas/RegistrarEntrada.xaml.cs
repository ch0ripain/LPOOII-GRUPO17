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
using System.Data;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for RegistrarEntrada.xaml
    /// </summary>
    public partial class RegistrarEntrada : Window
    {
        private string sectorID;
        public bool sectorNoDisponible { get; set; }

        public RegistrarEntrada()
        {
            InitializeComponent();
        }

        public RegistrarEntrada(string sectorId)
        {
            InitializeComponent();
            sectorID = sectorId;
        }

        private void btnRegistrarEntrada_Click(object sender, RoutedEventArgs e)
        {
            if (txtClienteDNI.Text == "" || txtPatente.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else {
                Ticket oTicket = new Ticket();
                oTicket.FechaHoraEnt = DateTime.Now;
                oTicket.TVCodigo = Int32.Parse(cmbTVCodigo.SelectedValue.ToString());
                oTicket.Patente = txtPatente.Text;
                oTicket.SectorCodigo = Int32.Parse(sectorID);
                oTicket.Duracion = 0;
                oTicket.Tarifa = decimal.Parse(txtTarifa.Text.Substring(1));
                oTicket.Total = oTicket.Tarifa;
                oTicket.ClienteDNI = int.Parse(txtClienteDNI.Text);
                oTicket.FechaHoraSal = DateTime.Now;

                MessageBoxResult result = MessageBox.Show("Desea generar este Ticket?\nFecha y hora de entrada: " + oTicket.FechaHoraEnt + "\nDNI del cliente: " + oTicket.ClienteDNI + "\nCódigo del TV: " + oTicket.TVCodigo + "\nPatente: " + oTicket.Patente + "\nCódigo del sector: " + oTicket.SectorCodigo + "\nTarifa: $" + oTicket.Tarifa + "\nTotal: S/D", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                this.sectorNoDisponible = false;
                if (result == MessageBoxResult.Yes)
                {
                    TrabajarTicket.AgregarTicket(oTicket);
                    //Cambiar el color del sector a rojo y actualizo el estado y la fecha del sector
                    this.sectorNoDisponible = true;
                    TrabajarSector.ModificarEstadoSectorNoDisponible(oTicket.SectorCodigo, oTicket.FechaHoraEnt);
                    this.Close();
                    VistaPreviaDeTicket vpdt = new VistaPreviaDeTicket();
                    vpdt.Show();
                }
            }      
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnRegistrarEntrada.IsEnabled = false;
            // DataTable con los tipos de vehículo
            DataTable dt = TrabajarTiposVehiculo.TraerTiposVehiculo();

            cmbTVCodigo.ItemsSource = dt.DefaultView;
            cmbTVCodigo.DisplayMemberPath = "Descripcion";
            cmbTVCodigo.SelectedValuePath = "TVCodigo";
            cmbTVCodigo.SelectedIndex = 0;

            // DataTable con los sectores
            //DataTable dts = TrabajarSector.TraerSectores();

            //cmbSectorCodigo.ItemsSource = dts.DefaultView;
            //cmbSectorCodigo.DisplayMemberPath = "Descripcion";
            //cmbSectorCodigo.SelectedValuePath = "SectorCodigo";
            //cmbSectorCodigo.SelectedIndex = 0;

            //Cargar el sector
            Sector sectorBuscado = new Sector();
            sectorBuscado = TrabajarSector.TraerSectorPorCodigo(sectorID);
            txtSector.Text = sectorBuscado.Descripcion + " - " + sectorBuscado.Identificador;

            //DNI del cliente
            txtClienteDNI.Text = "0"; //Falta un boton para buscar un cliente y poder seleccionarlo
        }

        private void cmbTVCodigo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedValue = cmbTVCodigo.SelectedValue;

            if (selectedValue != null)
            {
                string numero = selectedValue.ToString();
                int codigoSeleccionado;
    
                if (int.TryParse(numero, out codigoSeleccionado))
                {
                    // La conversión fue exitosa, ahora puedes usar 'codigoSeleccionado' como un entero
                    TipoVehiculo tv = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(codigoSeleccionado);
                    txtTarifa.Text = "$" + tv.Tarifa.ToString();
                }
                else
                {
                    // Manejar el caso donde la conversión no fue exitosa
                    Console.WriteLine("Error: No se pudo convertir el valor a un entero.");
                }
            }
            else
            {
                // Manejar el caso donde SelectedValue es nulo
                Console.WriteLine("Error: SelectedValue es nulo.");
            }


            
        }

        private void txtClienteDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtClienteDNI.Text != "")
            {
                Cliente clienteBuscado = new Cliente();
                clienteBuscado = TrabajarClientes.TraerCliente(int.Parse(txtClienteDNI.Text));
                if (clienteBuscado.Apellido != "")
                {
                    btnRegistrarEntrada.IsEnabled = true;
                }
                else
                {
                    btnRegistrarEntrada.IsEnabled = false;
                }
            }
        }

        private void txtClienteDNI_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el caracter ingresado no es un número
            if (!char.IsDigit(e.Text, 0))
            {
                // Cancelar el evento si no es un número
                e.Handled = true;
            }
        }

    }
}
