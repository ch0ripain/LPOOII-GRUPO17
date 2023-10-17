using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
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
                                    userName = reader["UserName"].ToString(),
                                    password = reader["Password"].ToString(),
                                    apellido = reader["Apellido"].ToString(),
                                    nombre = reader["Nombre"].ToString(),
                                    rol = reader["Rol"].ToString()
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

    }
}
