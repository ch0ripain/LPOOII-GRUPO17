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
        public bool agregarVehiculo { get; set; }
        public AgregarTipoVehiculo()
        {
            InitializeComponent();
        }

        private void btnCargarTipoVehiculo_Click(object sender, RoutedEventArgs e)
        {
            if (txtTipoVehiculoDescripcion.Text == "" || txtTipoVehiculoTarifa.Text == "" || txtImagen.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                TipoVehiculo oTipoVehiculo = new TipoVehiculo();
                oTipoVehiculo.Descripcion = txtTipoVehiculoDescripcion.Text;
                oTipoVehiculo.Tarifa = decimal.Parse(txtTipoVehiculoTarifa.Text);
                oTipoVehiculo.Imagen = txtImagen.Text;

                this.agregarVehiculo = false;

                MessageBoxResult result = MessageBox.Show("Desea agregar este tipo de vehiculo?\nDescripción: " + oTipoVehiculo.Descripcion + "\nTarifa: $" + oTipoVehiculo.Tarifa + "\nURI Imagen: " + oTipoVehiculo.Imagen, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    TrabajarTiposVehiculo.AgregarTipoVehiculo(oTipoVehiculo);
                    this.agregarVehiculo = true;
                    MessageBox.Show("Tipo de vehiculo agregado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
        }

        private void btnCargarImagen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtener la URL de la imagen desde el TextBox
                string urlImagen = txtImagen.Text;

                // Crear una instancia de la clase BitmapImage
                BitmapImage bitmapImage = new BitmapImage();

                // Asignar la URL de la imagen a la propiedad UriSource del objeto BitmapImage
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(urlImagen, UriKind.Absolute);
                bitmapImage.EndInit();

                // Asignar la imagen al control Image
                imgPreview.Source = bitmapImage; // Asegúrate de que "imgPreview" es el nombre del control Image en tu XAML
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void txtTipoVehiculoTarifa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Asegurarse de que solo se ingresen números y una coma
            if (!char.IsDigit(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Asegurarse de que solo haya una coma en la cadena
            TextBox textBox = (TextBox)sender;
            if (e.Text == "," && textBox.Text.Contains(","))
            {
                e.Handled = true; // Ignorar la segunda coma
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
