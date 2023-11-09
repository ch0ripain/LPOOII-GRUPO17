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
        private Usuario usuarioLog;
        public RegistrarEntrada()
        {
            InitializeComponent();
        }

        public RegistrarEntrada(Usuario log)
        {
            InitializeComponent();
            usuarioLog = log;
        }

        private void btnRegistrarEntrada_Click(object sender, RoutedEventArgs e)
        {
            if (txtClienteDNI.Text == "" || cmbTVCodigo.SelectedValue.ToString() == "" || txtPatente.ToString() == "" || cmbSectorCodigo.SelectedValue.ToString() == "" || txtTarifa.ToString() == "" || cmbDuracion.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Ticket oTicket = new Ticket();
                oTicket.FechaHoraEnt = DateTime.Now;
                oTicket.TVCodigo = Int32.Parse(cmbTVCodigo.SelectedValue.ToString());
                oTicket.Patente = txtPatente.Text;
                oTicket.SectorCodigo = Int32.Parse(cmbSectorCodigo.SelectedValue.ToString());
                oTicket.Duracion = decimal.Parse(cmbDuracion.SelectedValue.ToString());
                oTicket.Tarifa = decimal.Parse(txtTarifa.Text);
                oTicket.Total = oTicket.Tarifa * (oTicket.Duracion/60);
                oTicket.ClienteDNI = int.Parse(txtClienteDNI.Text);
                oTicket.FechaHoraSal = oTicket.FechaHoraEnt.AddMinutes(double.Parse(oTicket.Duracion.ToString()));

                MessageBoxResult result = MessageBox.Show("Desea generar este Ticket?\nFecha Hora Entrada: " + oTicket.FechaHoraEnt + "\nFecha Hora Salida: " + oTicket.FechaHoraSal + "\nCliente DNI: " + oTicket.ClienteDNI +"\nTVCodigo: " + oTicket.TVCodigo +"\nPatente: " + oTicket.Patente +"\nSector Codigo: " + oTicket.SectorCodigo +"\nDuracion: " + oTicket.Duracion + "\nTarifa: " + oTicket.Tarifa + "\nTotal: " + oTicket.Total, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    TrabajarTicket.AgregarTicket(oTicket);
                    MessageBox.Show("Ticket Generado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    VistaPreviaDeTicket vpdt = new VistaPreviaDeTicket(usuarioLog);
                    vpdt.Show();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // DataTable con los tipos de vehículo
            DataTable dt = TrabajarTiposVehiculo.TraerTiposVehiculo();

            cmbTVCodigo.ItemsSource = dt.DefaultView;
            cmbTVCodigo.DisplayMemberPath = "Descripcion";
            cmbTVCodigo.SelectedValuePath = "TVCodigo";
            cmbTVCodigo.SelectedIndex = 0;

            // DataTable con los sectores
            DataTable dts = TrabajarSector.TraerSectores();

            cmbSectorCodigo.ItemsSource = dts.DefaultView;
            cmbSectorCodigo.DisplayMemberPath = "Descripcion";
            cmbSectorCodigo.SelectedValuePath = "SectorCodigo";
            cmbSectorCodigo.SelectedIndex = 0;
        }

        private void cmbTVCodigo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TipoVehiculo tv = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(cmbTVCodigo.SelectedValue.ToString());
            txtTarifa.Text = tv.Tarifa.ToString();
        }

    }
}
