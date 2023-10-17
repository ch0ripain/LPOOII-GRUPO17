using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarClientes
    {
        public static Cliente TraerCliente(int dni)
        {
            Cliente clienteEncontrado = null;
            // Realizar la consulta SQL para buscar al cliente por su DNI
            string consulta = "SELECT Apellido, Nombre, Telefono FROM Cliente WHERE ClienteDNI = @dni";
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);

                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // El cliente se encontró en la base de datos
                                clienteEncontrado = new Cliente
                                {
                                    apellido = reader["Apellido"].ToString(),
                                    nombre = reader["Nombre"].ToString(),
                                    telefono = reader["Telefono"].ToString()
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
            return clienteEncontrado;
        }

    }
}
