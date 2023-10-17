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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //HardCoded

            //oUsuarioAdmin.nombre = "Leandro";
            //oUsuarioAdmin.apellido = "Rufino";
            //oUsuarioAdmin.userName = "Admin";
            //oUsuarioAdmin.password = "admin";
            //oUsuarioAdmin.rol = "Admin";

            //Usuario oUsuarioOperador = new Usuario();
            //oUsuarioOperador.nombre = "Amaru";
            //oUsuarioOperador.apellido = "Sedgovia";
            //oUsuarioOperador.userName = "Operador";
            //oUsuarioOperador.password = "operador";
            //oUsuarioOperador.rol = "Operador";

            //string usuarioIngresado = login.Usuario; // Obtener el nombre de usuario ingresado
            //string contrasenaIngresada = login.Contraseña; // Obtener la contraseña ingresada

            //// Verificar las credenciales ingresadas
            //if (usuarioIngresado == oUsuarioAdmin.userName && contrasenaIngresada == oUsuarioAdmin.password)
            //{
            //    // Acceso concedido para el usuario "Admin"
            //    MessageBox.Show("Bienvenido, Admin", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            //    Menu oMenu = new Menu(oUsuarioAdmin.rol);
            //    oMenu.Show();
            //    // Ocultar la ventana de inicio de sesión
            //    this.Hide();
            //}
            //else if (usuarioIngresado == oUsuarioOperador.userName && contrasenaIngresada == oUsuarioOperador.password)
            //{
            //    // Acceso concedido para el usuario "Operador"
            //    MessageBox.Show("Bienvenido, Operador", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            //    Menu oMenu = new Menu(oUsuarioOperador.rol);
            //    oMenu.Show();
            //    // Ocultar la ventana de inicio de sesión
            //    this.Hide();
            //}
            //else
            //{
            //    // Credenciales incorrectas
            //    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            //Usando el metodo ValidarUsuario

            Usuario oUsuarioBuscado = new Usuario();
            oUsuarioBuscado = TrabajarUsuario.ValidarUsuario(login.Usuario, login.Contraseña); //Retorna objeto de tipo Usuario si lo encuentra

            if (oUsuarioBuscado == null)
            {
                MessageBox.Show("Usuario no encontrado!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (oUsuarioBuscado.rol == "Admin")
                {
                    MessageBox.Show("Bienvenido, Admin " + oUsuarioBuscado.apellido, "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    Menu oMenu = new Menu(oUsuarioBuscado.rol);
                    oMenu.Show();
                    this.Hide();
                }
                else
                {
                    if (oUsuarioBuscado.rol == "Operador")
                    {
                        MessageBox.Show("Bienvenido, Operador " + oUsuarioBuscado.apellido, "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        Menu oMenu = new Menu(oUsuarioBuscado.rol);
                        oMenu.Show();
                        this.Hide();
                    }
                }
            }
           
        }
    }
}
