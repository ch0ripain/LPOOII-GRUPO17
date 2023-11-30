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
    /// Interaction logic for ListadoDeVentas.xaml
    /// </summary>
    public partial class ListadoDeVentas : Window
    {
        CollectionViewSource vistaColleccionFiltrada;
        private static DateTime fechaDesde;
        private static DateTime fechaHasta;
        private static decimal total;
        public ListadoDeVentas()
        {
            InitializeComponent();
            //Accedemos al recurso CollectionViewSource
            vistaColleccionFiltrada = (CollectionViewSource)(this.Resources["VentasFiltradas"]);
            total = TrabajarTicket.ObtenerTotalVentasXRango(fechaDesde, fechaHasta);
            if (lblTotal != null)
            {
                // Accede a lblTotal.Content aquí
                lblTotal.Content = "Total: $" + total.ToString();
            }
        }

        private void View_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

        }


        public static DateTime ObtenerFechaDesde() 
        {
            return fechaDesde;
        }

        public static DateTime ObtenerFechaHasta()
        {
            return fechaHasta;
        }

        public static Decimal ObtenerTotal()
        {
            return total;
        }

        private void dtpRango_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            total = 0;
            if (vistaColleccionFiltrada != null)
            {
                //Se va invocando al metodo event filter a medida que el texto cambie
                vistaColleccionFiltrada.Filter += eventVistaFecha_Filter;
                 
            }

            DateTime? fechaInicio = dtpInicio != null ? dtpInicio.SelectedDate : null;
            DateTime? fechaFinal = dtpFinal != null ? dtpFinal.SelectedDate : null;

            if (fechaInicio.HasValue && fechaFinal.HasValue)
            {
                fechaDesde = fechaInicio.Value;
                fechaHasta = fechaFinal.Value;
                //Actualizo el total de ventas
                total = TrabajarTicket.ObtenerTotalVentasXRango(fechaDesde, fechaHasta);
                if (lblTotal != null)
                {
                    // Accede a lblTotal.Content aquí
                    lblTotal.Content = "Total: $" + total.ToString();
                }
            }
        }

        private void eventVistaFecha_Filter(object sender, FilterEventArgs e)
        {
            dynamic ventaTicket = e.Item;

            if (ventaTicket != null)
            {
                DateTime? fechaInicio = dtpInicio != null ? dtpInicio.SelectedDate : null;
                DateTime? fechaFinal = dtpFinal != null ? dtpFinal.SelectedDate : null;

                // Acceder a la propiedad FechaHoraEnt usando reflexión
                if (fechaInicio.HasValue && fechaFinal.HasValue)
                {
                    if (ventaTicket.FechaHoraEnt >= fechaInicio && ventaTicket.FechaHoraEnt <= fechaFinal)
                    {
                        // La fecha está dentro del rango
                        e.Accepted = true;
                    }
                    else
                    {
                        // La fecha está fuera del rango
                        e.Accepted = false;
                    }
                }
                else
                {
                    // No hay fechas seleccionadas, aceptar todo
                    e.Accepted = true;
                }
            }
        }

        private void btnVistaPrevia_Click(object sender, RoutedEventArgs e)
        {
            VistaPreviaDeImpresionListadoVentas vpdilv = new VistaPreviaDeImpresionListadoVentas(vistaColleccionFiltrada);
            vpdilv.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fechaDesde = new DateTime(2023, 1, 1);
            fechaHasta = new DateTime(2023, 12, 31);

        }

    }
}
