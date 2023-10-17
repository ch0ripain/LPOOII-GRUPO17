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
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCargarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtClienteDNI.Text == "" || txtClienteNombre.Text == "" || txtClienteApellido.Text == "" || txtClienteTelefono.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Cliente oCliente = new Cliente();
                oCliente.clienteDNI = int.Parse(txtClienteDNI.Text);
                oCliente.nombre = txtClienteNombre.Text;
                oCliente.apellido = txtClienteApellido.Text;
                oCliente.telefono = txtClienteTelefono.Text;

                MessageBoxResult result = MessageBox.Show("Desea agregar este cliente?\nDNI: "+ oCliente.clienteDNI + "\nNombre: " + oCliente.nombre + "\nApellido: " + oCliente.apellido + "\nTeléfono: " + oCliente.telefono, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Cliente agregado!");
            }
            }
        }
    }
}
