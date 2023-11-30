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
    /// Interaction logic for AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : Window
    {
        public bool clienteAgregado { get; set; }
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCargarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtClienteDNI.Text == "" || txtClienteNombre.Text == "" || txtClienteApellido.Text == "" || txtClienteTelefono.Text == "" || txtClienteDNI.Text == "0")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Cliente oCliente = new Cliente();
                oCliente.ClienteDNI = int.Parse(txtClienteDNI.Text);
                oCliente.Nombre = txtClienteNombre.Text;
                oCliente.Apellido = txtClienteApellido.Text;
                oCliente.Telefono = txtClienteTelefono.Text;

                MessageBoxResult result = MessageBox.Show("Desea agregar este cliente?\nDNI: "+ oCliente.ClienteDNI + "\nNombre: " + oCliente.Nombre + "\nApellido: " + oCliente.Apellido + "\nTeléfono: " + oCliente.Telefono, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                this.clienteAgregado = false;
            if (result == MessageBoxResult.Yes)
            {
                TrabajarClientes.AgregarCliente(oCliente);
                this.clienteAgregado = true;
                MessageBox.Show("Cliente agregado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            }
        }

        private void txtClienteDNI_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el caracter ingresado no es un número
            if (!char.IsDigit(e.Text, 0))
            {
                // Cancelar el evento si no es un número
                e.Handled = true;
            }
        }

        private void txtClienteTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el caracter ingresado no es un número
            if (!char.IsDigit(e.Text, 0))
            {
                // Cancelar el evento si no es un número
                e.Handled = true;
            }
        }

    }
}
