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
    /// Interaction logic for VistaPreviaDeImpresionListadoSectoresOcupados.xaml
    /// </summary>
    public partial class VistaPreviaDeImpresionListadoSectoresOcupados : Window
    {
        public VistaPreviaDeImpresionListadoSectoresOcupados()
        {
            InitializeComponent();
        }

        public VistaPreviaDeImpresionListadoSectoresOcupados(CollectionViewSource cvs)
        {
            InitializeComponent();
            lsvSector.DataContext = cvs;
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
    }
}
