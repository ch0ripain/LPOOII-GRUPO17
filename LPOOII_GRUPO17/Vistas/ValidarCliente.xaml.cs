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
    /// Interaction logic for ValidarCliente.xaml
    /// </summary>
    public partial class ValidarCliente : Window
    {
        public ValidarCliente()
        {
            InitializeComponent();
        }

        private void txtClienteDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            int dni;
            if (int.TryParse(txtClienteDNI.Text, out dni))
            {
                var dataCliente = this.FindResource("DATA_CLIENTE") as ObjectDataProvider;
                 if (dataCliente != null)
                 {
                    dataCliente.MethodParameters[0] = dni;
                 }
            }
        }

        private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtClienteDNI.Text == "" || txtClienteNombre.Text == "" || txtClienteApellido.Text == "" || txtClienteTelefono.Text == "")
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

                MessageBoxResult result = MessageBox.Show("Desea modificar este cliente?\nDNI: " + oCliente.ClienteDNI + "\nNombre: " + oCliente.Nombre + "\nApellido: " + oCliente.Apellido + "\nTeléfono: " + oCliente.Telefono, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Cliente modificado!");
                }
            }
        }
    }
}
