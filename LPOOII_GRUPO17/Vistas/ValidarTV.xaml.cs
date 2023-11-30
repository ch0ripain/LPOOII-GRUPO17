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
    /// Interaction logic for ValidarTV.xaml
    /// </summary>
    public partial class ValidarTV : Window
    {
        public bool tvModificado { get; set; }
        public ValidarTV()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            int codigo;
            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                TipoVehiculo tv = new TipoVehiculo();
                tv = TrabajarTiposVehiculo.TraerTipoVehiculoPorCodigo(codigo);
                if (tv.Descripcion != "")
                {
                    txtImagen.Text = tv.Imagen;
                    txtTipoVehiculoDescripcion.Text = tv.Descripcion;
                    txtTipoVehiculoTarifa.Text = "$" + tv.Tarifa.ToString();
                    btnModificar.IsEnabled = true;
                }
                else if(tv.Descripcion == "" || txtCodigo.Text == ""){
                    btnModificar.IsEnabled = false;
                    txtImagen.Text = "";
                    txtTipoVehiculoDescripcion.Text = "";
                    txtTipoVehiculoTarifa.Text = "";
                }
                
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text == "" || txtImagen.Text == "" || txtTipoVehiculoDescripcion.Text == "" || txtTipoVehiculoTarifa.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                TipoVehiculo oTV = new TipoVehiculo();
                oTV.TVCodigo = int.Parse(txtCodigo.Text);
                oTV.Descripcion = txtTipoVehiculoDescripcion.Text;
                oTV.Tarifa = decimal.Parse(txtTipoVehiculoTarifa.Text.Substring(1));
                oTV.Imagen = txtImagen.Text;

                MessageBoxResult result = MessageBox.Show("Desea modificar este tipo de vehiculo?\nTVCodigo: " + oTV.TVCodigo + "\nDescripcion: " + oTV.Descripcion + "\nTarifa: " + oTV.Tarifa + "\nImagen: " + oTV.Imagen, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                this.tvModificado = false;

                if (result == MessageBoxResult.Yes)
                {
                    TrabajarTiposVehiculo.ModificarTipoVehiculo(oTV);
                    this.tvModificado = true;
                    MessageBox.Show("Tipo de vehiculo modificado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnModificar.IsEnabled = false;
        }

        private void txtCodigo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el caracter ingresado no es un número
            if (!char.IsDigit(e.Text, 0))
            {
                // Cancelar el evento si no es un número
                e.Handled = true;
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
    }
}
