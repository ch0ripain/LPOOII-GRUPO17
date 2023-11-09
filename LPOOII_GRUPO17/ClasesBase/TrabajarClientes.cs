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
            Cliente clienteEncontrado = new Cliente();
            //clienteEncontrado.clienteDNI = null;
            clienteEncontrado.Nombre = "";
            clienteEncontrado.Apellido = "";
            clienteEncontrado.Telefono = "";
            if (dni > 0)
            {
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
                                        Apellido = reader["Apellido"].ToString(),
                                        Nombre = reader["Nombre"].ToString(),
                                        Telefono = reader["Telefono"].ToString()
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
            }

                return clienteEncontrado;
        }

        public static Cliente TraerClienteNuevo()
        {
            Cliente oCliente = new Cliente();
            //oCliente.clienteDNI = null;
            oCliente.Nombre = "";
            oCliente.Apellido = "";
            oCliente.Telefono = "";
            return oCliente;
        }
    }
}
