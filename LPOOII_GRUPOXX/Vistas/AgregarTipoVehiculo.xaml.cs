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
    /// Interaction logic for AgregarTipoVehiculo.xaml
    /// </summary>
    public partial class AgregarTipoVehiculo : Window
    {
        public AgregarTipoVehiculo()
        {
            InitializeComponent();
        }

        private void btnCargarTipoVehiculo_Click(object sender, RoutedEventArgs e)
        {
            if (txtTipoVehiculoDescripcion.Text == "" || txtTipoVehiculoTarifa.Text == "" || txtTipoVehiculoTVCodigo.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                TipoVehiculo oTipoVehiculo = new TipoVehiculo();
                oTipoVehiculo.descripcion = txtTipoVehiculoDescripcion.Text;
                oTipoVehiculo.tarifa = decimal.Parse(txtTipoVehiculoTarifa.Text);
                oTipoVehiculo.tvCodigo = int.Parse(txtTipoVehiculoTVCodigo.Text);

                MessageBoxResult result = MessageBox.Show("Desea agregar este tipo de vehiculo?\nDescripción: " + oTipoVehiculo.descripcion + "\nTarifa: " + oTipoVehiculo.tarifa + "\nTV Código: " + oTipoVehiculo.tvCodigo, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Tipo de vehiculo agregado!");
                }
            }
        }
    }
}
