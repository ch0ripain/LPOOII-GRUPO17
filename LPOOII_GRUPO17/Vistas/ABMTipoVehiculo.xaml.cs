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
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMTipoVehiculo.xaml
    /// </summary>
    public partial class ABMTipoVehiculo : Window
    {
        CollectionView Vista;
        ObservableCollection<TipoVehiculo> listaTV;
        public ABMTipoVehiculo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_TV"];
            listaTV = odp.Data as ObservableCollection<TipoVehiculo>;

            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);

        }

        private void btnNuevoTV_Click(object sender, RoutedEventArgs e)
        {
            AgregarTipoVehiculo oAgregarTV = new AgregarTipoVehiculo();
            oAgregarTV.ShowDialog();
            if (oAgregarTV.agregarVehiculo == true)
            {
                ActualizarListaTV();
                Vista.MoveCurrentToLast();
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            ValidarTV oVTV = new ValidarTV();
            oVTV.ShowDialog();
            if(oVTV.tvModificado == true)
            {
                ActualizarListaTV();
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarTipoVehiculo oListarTV = new ListarTipoVehiculo();
            oListarTV.Show();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea eliminar este tipo de vehiculo?\nTVCodigo: " + txtTVCodigo.Text + "\nDescripción: " + txtDescripcion.Text + "\nTarifa: " + txtTarifa.Text + "\nImagen: " + txtImagen.Text, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                TrabajarTiposVehiculo.EliminarTipoVehiculo(int.Parse(txtTVCodigo.Text));
                MessageBox.Show("Tipo de vehiculo eliminado con éxito!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                ActualizarListaTV();
                Vista.MoveCurrentToLast();
            }
        }

        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (Vista.CurrentPosition == 0)
            {
                Vista.MoveCurrentToLast(); // Ir al último elemento de la colección
            }
            else
            {
                Vista.MoveCurrentToPrevious();
            }
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (Vista.CurrentPosition == Vista.Count - 1)
            {
                Vista.MoveCurrentToFirst(); // Ir al primer elemento de la colección
            }
            else
            {
                Vista.MoveCurrentToNext();
            }
        }

        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void ActualizarListaTV()
        {
            // Llama al método para obtener la lista actualizada de usuarios
            ObservableCollection<TipoVehiculo> tvActualizados = TrabajarTiposVehiculo.TraerTiposVehiculos();

            // Asigna la nueva lista al DataContext
            canvas_content.DataContext = tvActualizados;

            // Crea la vista de nuevo con la lista actualizada
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
        }

    }
}
