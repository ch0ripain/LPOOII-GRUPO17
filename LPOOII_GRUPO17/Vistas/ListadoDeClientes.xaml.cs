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
    /// Interaction logic for ListadoDeClientes.xaml
    /// </summary>
    public partial class ListadoDeClientes : Window
    {
        CollectionViewSource vistaColleccionFiltrada;
        public ListadoDeClientes()
        {
            InitializeComponent();
            //Accedemos al recurso CollectionViewSource
            vistaColleccionFiltrada = (CollectionViewSource)(this.Resources["ClientesFiltrados"]);
        }

        private void txtDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColleccionFiltrada != null)
            {
                //Se va invocando al metodo event filter a medida que el texto cambie
                vistaColleccionFiltrada.Filter += eventVistaCliente_Filter;
            }
        }

        private void eventVistaCliente_Filter(object sender, FilterEventArgs e)
        {
            Cliente cliente = (Cliente)e.Item;

            // Se realiza la búsqueda por el DNI (considerando que txtDNI.Text es un TextBox)
            string filtroDNI = txtDNI.Text;

            // Convierte el DNI del cliente a cadena para realizar la comparación
            string clienteDNIString = cliente.ClienteDNI.ToString();

            // Realiza la comparación ignorando mayúsculas y minúsculas
            if (clienteDNIString.StartsWith(filtroDNI, StringComparison.CurrentCultureIgnoreCase))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private void btnVistaPrevia_Click(object sender, RoutedEventArgs e)
        {
            VistaPreviaDeImpresionClientes vpdi = new VistaPreviaDeImpresionClientes(vistaColleccionFiltrada);
            vpdi.Show();
        }

    }
}
