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
    /// Interaction logic for ListadoDeSectoresOcupados.xaml
    /// </summary>
    public partial class ListadoDeSectoresOcupados : Window
    {
        CollectionViewSource vistaColleccionSectoresOcupados;
        public ListadoDeSectoresOcupados()
        {
            InitializeComponent();

            //Accedemos al recurso CollectionViewSource
            vistaColleccionSectoresOcupados = (CollectionViewSource)(this.Resources["SectoresOcupados"]);
        }

        private void btnVistaPrevia_Click(object sender, RoutedEventArgs e)
        {
            VistaPreviaDeImpresionListadoSectoresOcupados vpdilso = new VistaPreviaDeImpresionListadoSectoresOcupados(vistaColleccionSectoresOcupados);
            vpdilso.Show();
        }
    }
}
