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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VistaPreviaDeImpresionListadoVentas.xaml
    /// </summary>
    public partial class VistaPreviaDeImpresionListadoVentas : Window
    {
        public VistaPreviaDeImpresionListadoVentas()
        {
            InitializeComponent();
        }

        public VistaPreviaDeImpresionListadoVentas(CollectionViewSource cvs)
        {
            InitializeComponent();
            lsvVenta.DataContext = cvs;
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(((IDocumentPaginatorSource)
                DocMain).DocumentPaginator, "Impresión Documento Dinámico");
            } 
        }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                DateTime fDesde = ListadoDeVentas.ObtenerFechaDesde();
                DateTime fHasta = ListadoDeVentas.ObtenerFechaHasta();

                string fDesdeFormateada = fDesde.ToString("dd/MM/yy");
                string fHastaFormateada = fHasta.ToString("dd/MM/yy");

                prgTitulo.Inlines.Clear(); // Limpiar el contenido actual
                prgTitulo.Inlines.Add(new Run("LISTADO DE VENTAS - " + "Desde " + fDesdeFormateada + " hasta " + fHastaFormateada));

                prgTotal.Inlines.Clear(); // Limpiar el contenido actual
                prgTotal.Inlines.Add(new Run("TOTAL: $" + ListadoDeVentas.ObtenerTotal()));
            }
    }
}
