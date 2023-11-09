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
    /// Interaction logic for VistaPreviaDeImpresion.xaml
    /// </summary>
    public partial class VistaPreviaDeImpresion : Window
    {
        public VistaPreviaDeImpresion()
        {
            InitializeComponent();
        }

        public VistaPreviaDeImpresion(CollectionViewSource cvs)
        {
            InitializeComponent();
            lsvUsuario.DataContext = cvs;
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
