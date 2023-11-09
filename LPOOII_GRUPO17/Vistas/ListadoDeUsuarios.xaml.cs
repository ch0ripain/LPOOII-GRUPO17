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
    /// Interaction logic for ListadoDeUsuarios.xaml
    /// </summary>
    public partial class ListadoDeUsuarios : Window
    {
        CollectionViewSource vistaColleccionFiltrada;
        public ListadoDeUsuarios()
        {
            InitializeComponent();

            //Accedemos al recurso CollectionViewSource
            vistaColleccionFiltrada = (CollectionViewSource)(this.Resources["UsuariosFiltrados"]);
        }

        private void txtUserNameFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColleccionFiltrada != null)
            { 
                //Se va invocando al metodo event filter a medida que el texto cambie
                vistaColleccionFiltrada.Filter += eventVistaUsuario_Filter;
            }
        }



        private void eventVistaUsuario_Filter(object sender, FilterEventArgs e)
        {
            Usuario usuario = (Usuario) e.Item;

            //Se realiza la busqueda por el UserName
            if (usuario.UserName.StartsWith(txtUserNameFiltro.Text, StringComparison.CurrentCultureIgnoreCase))
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
            VistaPreviaDeImpresion vpdi = new VistaPreviaDeImpresion(vistaColleccionFiltrada);
            vpdi.Show();
        }
    }
}
