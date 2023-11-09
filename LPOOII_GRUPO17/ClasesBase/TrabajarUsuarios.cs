using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuarios
    {
        public static Usuario ValidarUsuario(string nombre, string password)
        {
            Usuario usuarioEncontrado = null;

            // Realizar la consulta SQL para buscar al usuario por su nombre de usuario y contraseña
            string consulta = "SELECT UserName, Password, Apellido, Nombre, Rol FROM Usuario WHERE UserName = @usuario AND Password = @password";
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", nombre);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // El usuario se encontró en la base de datos
                                usuarioEncontrado = new Usuario
                                {
                                    UserName = reader["UserName"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Nombre = reader["Nombre"].ToString(),
                                    Rol = reader["Rol"].ToString()
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return usuarioEncontrado;
        }

        public static ObservableCollection<Usuario> TraerUsuarios()
        {
            ObservableCollection<Usuario> listaUsuario = new ObservableCollection<Usuario>();

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();
                string query = "SELECT UserName, Password, Apellido, Nombre, Rol FROM Usuario";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            UserName = reader.GetString(0),
                            Password = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Nombre = reader.GetString(3),
                            Rol = reader.GetString(4)
                        };
                        listaUsuario.Add(usuario);
                    }
                }
            }

            return listaUsuario;
        }

        public static ObservableCollection<Usuario> TraerUsuariosxUserName()
        {
            ObservableCollection<Usuario> listaUsuario = new ObservableCollection<Usuario>();


            return listaUsuario;
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

               
                string consulta = "INSERT INTO Usuario(UserName,Password,Apellido,Nombre,Rol) values (@userName,@password,@apellido,@nombre,@rol)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@userName", usuario.UserName);
                    cmd.Parameters.AddWithValue("@password", usuario.Password);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@rol", usuario.Rol);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModificarUsuario(Usuario usuario, string cod)
        {
            string consulta = "UPDATE Usuario SET UserName = @userName, Password = @password, Apellido = @apellido, Nombre = @nombre, Rol = @rol WHERE UserName = @cod";

            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString);

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@userName", usuario.UserName);
            cmd.Parameters.AddWithValue("@password", usuario.Password);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol);

            conexion.Open();
            cmd.ExecuteNonQuery();
        }

        public static void EliminarUsuario(string userName)
        {
            string consulta = "DELETE FROM Usuario WHERE UserName = @userName";
            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString);

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@userName", userName);
            conexion.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
