using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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

        public static void AgregarCliente(Cliente nuevoCliente)
        {
            // La cadena de conexión debe coincidir con tu configuración
            string cadenaConexion = ClasesBase.Properties.Settings.Default.playaConnectionString;

            // Sentencia SQL INSERT
            string consulta = "INSERT INTO Cliente (ClienteDNI,Apellido, Nombre, Telefono) VALUES (@ClienteDNI,@Nombre, @Apellido, @Telefono)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    // Parámetros
                    cmd.Parameters.AddWithValue("@ClienteDNI", nuevoCliente.ClienteDNI);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoCliente.Apellido);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error al agregar cliente: " + ex.Message);
                    }
                }
            }
        }

        public static void ModificarCliente(Cliente clienteModificado)
        {
            // La cadena de conexión debe coincidir con tu configuración
            string cadenaConexion = ClasesBase.Properties.Settings.Default.playaConnectionString;

            // Sentencia SQL UPDATE
            string consulta = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono WHERE ClienteDNI = @ClienteDNI";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    // Parámetros
                    cmd.Parameters.AddWithValue("@ClienteDNI", clienteModificado.ClienteDNI); // Asegúrate de tener la propiedad ClienteDNI en tu clase Cliente
                    cmd.Parameters.AddWithValue("@Nombre", clienteModificado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", clienteModificado.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", clienteModificado.Telefono);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error al modificar cliente: " + ex.Message);
                    }
                }
            }
        }

        public static void EliminarCliente(int dni)
        {
            // La cadena de conexión debe coincidir con tu configuración
            string cadenaConexion = ClasesBase.Properties.Settings.Default.playaConnectionString;

            // Sentencia SQL DELETE
            string consulta = "DELETE FROM Cliente WHERE ClienteDNI = @ClienteDNI";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    // Parámetros
                    cmd.Parameters.AddWithValue("@ClienteDNI", dni);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error al eliminar cliente: " + ex.Message);
                    }
                }
            }
        }

        public static ObservableCollection<Cliente> TraerClientes()
        {
            ObservableCollection<Cliente> listaClientes = new ObservableCollection<Cliente>();
            Cliente cliente = null;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();
                string query = "SELECT ClienteDNI, Nombre, Apellido, Telefono FROM Cliente";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            ClienteDNI = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Telefono = reader.GetString(3)
                        };

                        // Agregar objeto a la colección
                        listaClientes.Add(cliente);
                    }
                }
            }

            return listaClientes;
        }




    }
}
