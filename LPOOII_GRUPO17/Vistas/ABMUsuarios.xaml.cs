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
using System.Collections.ObjectModel;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMUsuarios.xaml
    /// </summary>
    public partial class ABMUsuarios : Window
    {
        CollectionView Vista;
        ObservableCollection<Usuario> listaUsuario;

        public ABMUsuarios()
        {
            InitializeComponent();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_USER"];
            listaUsuario = odp.Data as ObservableCollection<Usuario>;

            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);

            btnCancelar.IsEnabled = false;
            btnGuardar.IsEnabled = false;
            txtNewUserName.Visibility = Visibility.Collapsed;
            txtNewPassword.Visibility = Visibility.Collapsed;
            txtNewApellido.Visibility = Visibility.Collapsed;
            txtNewNombre.Visibility = Visibility.Collapsed;
            cmbNewRol.Visibility = Visibility.Collapsed;
        }

        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.IsEnabled = true;
            btnGuardar.IsEnabled = true;

            txtNewUserName.Visibility = Visibility.Visible;
            txtNewPassword.Visibility = Visibility.Visible;
            txtNewApellido.Visibility = Visibility.Visible;
            txtNewNombre.Visibility = Visibility.Visible;
            cmbNewRol.Visibility = Visibility.Visible;

            txtNewUserName.Text = "";
            txtNewPassword.Text = "";
            txtNewApellido.Text = "";
            txtNewNombre.Text = "";

            btnGuardar.Content = "Guardar";
        }

        private void btnEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea eliminar este usuario?\nNombre de usuario: " + txtUserName.Text + "\nContraseña: " + txtPassword.Text + "\nApellido: " + txtApellido.Text + "\nNombre: " + txtNombre.Text + "\nRol: " + cmbRol.SelectedValue, "Información", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                TrabajarUsuarios.EliminarUsuario(txtUserName.Text);
                MessageBox.Show("Usuario eliminado con éxito!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                ActualizarListaUsuarios();
                Vista.MoveCurrentToLast();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.IsEnabled = false;
            btnGuardar.IsEnabled = false;

            txtNewUserName.Visibility = Visibility.Collapsed;
            txtNewPassword.Visibility = Visibility.Collapsed;
            txtNewApellido.Visibility = Visibility.Collapsed;
            txtNewNombre.Visibility = Visibility.Collapsed;
            cmbNewRol.Visibility = Visibility.Collapsed;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNewApellido.Text == "" || txtNewNombre.Text == "" || txtNewPassword.Text == "" || txtNewUserName.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Desea confirmar la operación?\nNombre de usuario: " + txtNewUserName.Text + "\nContraseña: " + txtNewPassword.Text + "\nApellido: " + txtNewApellido.Text + "\nNombre: " + txtNewNombre.Text + "\nRol: " + cmbNewRol.SelectedValue, "Información", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.UserName = txtNewUserName.Text;
                    oUsuario.Password = txtNewPassword.Text;
                    oUsuario.Apellido = txtNewApellido.Text;
                    oUsuario.Nombre = txtNewNombre.Text;
                    oUsuario.Rol = cmbNewRol.SelectedValue.ToString();

                    if (btnGuardar.Content.ToString() == "Guardar")
                    {
                        TrabajarUsuarios.AgregarUsuario(oUsuario);
                        MessageBox.Show("Usuario agregado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        ActualizarListaUsuarios();
                        Vista.MoveCurrentToLast();
                        btnCancelar.IsEnabled = false;
                        btnGuardar.IsEnabled = false;
                        txtNewUserName.Visibility = Visibility.Collapsed;
                        txtNewPassword.Visibility = Visibility.Collapsed;
                        txtNewApellido.Visibility = Visibility.Collapsed;
                        txtNewNombre.Visibility = Visibility.Collapsed;
                        cmbNewRol.Visibility = Visibility.Collapsed;
                    }
                    else if (btnGuardar.Content.ToString() == "Modificar")
                    {
                        int currentPosition = Vista.CurrentPosition;
                        TrabajarUsuarios.ModificarUsuario(oUsuario, txtUserName.Text);
                        MessageBox.Show("Usuario modificado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        ActualizarListaUsuarios();
                        Vista.MoveCurrentToPosition(currentPosition);
                        btnCancelar.IsEnabled = false;
                        btnGuardar.IsEnabled = false;
                        txtNewUserName.Visibility = Visibility.Collapsed;
                        txtNewPassword.Visibility = Visibility.Collapsed;
                        txtNewApellido.Visibility = Visibility.Collapsed;
                        txtNewNombre.Visibility = Visibility.Collapsed;
                        cmbNewRol.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.IsEnabled = true;
            btnGuardar.IsEnabled = true;

            txtNewUserName.Visibility = Visibility.Visible;
            txtNewUserName.Text = txtUserName.Text;
            txtNewPassword.Visibility = Visibility.Visible;
            txtNewPassword.Text = txtPassword.Text;
            txtNewApellido.Visibility = Visibility.Visible;
            txtNewApellido.Text = txtApellido.Text;
            txtNewNombre.Visibility = Visibility.Visible;
            txtNewNombre.Text = txtNombre.Text;
            cmbNewRol.Visibility = Visibility.Visible;
            cmbNewRol.SelectedValue = cmbRol.SelectedValue;

            btnGuardar.Content = "Modificar";
        }

        private void ActualizarListaUsuarios()
        {
            // Llama al método para obtener la lista actualizada de usuarios
            ObservableCollection<Usuario> usuariosActualizados = TrabajarUsuarios.TraerUsuarios();

            // Asigna la nueva lista al DataContext
            canvas_content.DataContext = usuariosActualizados;

            // Crea la vista de nuevo con la lista actualizada
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
        }

    }
}
