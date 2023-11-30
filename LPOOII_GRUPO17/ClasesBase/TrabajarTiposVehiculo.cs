using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarTiposVehiculo
    {
        public static DataTable TraerTiposVehiculo()
        {
            using (DataTable dt = new DataTable())
            {
                using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT TVCodigo, Descripcion, Tarifa, Imagen FROM TipoVehiculo", cn))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public static TipoVehiculo TraerTipoVehiculoPorCodigo(int codigoTipoVehiculo)
        {
            TipoVehiculo tv = new TipoVehiculo();
            tv.TVCodigo = 0;
            tv.Descripcion = "";
            tv.Tarifa = 0;
            tv.Imagen = "";
            if (codigoTipoVehiculo > 0)
            {
                // Realizar la consulta SQL para buscar al cliente por su DNI
                string consulta = "SELECT Descripcion, Tarifa, Imagen FROM TipoVehiculo WHERE TVCodigo = @cod";
                using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cod", codigoTipoVehiculo);

                        try
                        {
                            conexion.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // El cliente se encontró en la base de datos
                                    tv = new TipoVehiculo
                                    {
                                        Descripcion = reader["Descripcion"].ToString(),
                                        Tarifa = reader.GetDecimal(reader.GetOrdinal("Tarifa")),
                                        Imagen = reader["Imagen"].ToString()
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

            return tv;
        }

        public static void AgregarTipoVehiculo(TipoVehiculo nuevoTipoVehiculo)
        {
            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

                // Sentencia SQL
                string consulta = "INSERT INTO TipoVehiculo(Descripcion,Tarifa,Imagen) values (@descripcion,@tarifa,@imagen)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@descripcion", nuevoTipoVehiculo.Descripcion);
                    cmd.Parameters.AddWithValue("@tarifa", nuevoTipoVehiculo.Tarifa);
                    cmd.Parameters.AddWithValue("@imagen", nuevoTipoVehiculo.Imagen);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModificarTipoVehiculo(TipoVehiculo tipoVehiculoModificado)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                string query = "UPDATE TipoVehiculo SET Descripcion = @Descripcion, Tarifa = @Tarifa, Imagen = @Imagen WHERE TVCodigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", tipoVehiculoModificado.TVCodigo);
                    cmd.Parameters.AddWithValue("@Descripcion", tipoVehiculoModificado.Descripcion);
                    cmd.Parameters.AddWithValue("@Tarifa", tipoVehiculoModificado.Tarifa);
                    cmd.Parameters.AddWithValue("@Imagen", tipoVehiculoModificado.Imagen);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error al modificar tipo de vehículo: " + ex.Message);
                    }
                }
            }
        }

        public static void EliminarTipoVehiculo(int codigoTipoVehiculo)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                string query = "DELETE FROM TipoVehiculo WHERE TVCodigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoTipoVehiculo);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error de la base de datos
                        Console.WriteLine("Error al eliminar tipo de vehículo: " + ex.Message);
                    }
                }
            }
        }

        public static ObservableCollection<TipoVehiculo> TraerTiposVehiculos()
        {
            ObservableCollection<TipoVehiculo> listaTiposVehiculo = new ObservableCollection<TipoVehiculo>();
            TipoVehiculo tipoVehiculo = null;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();
                string query = "SELECT TVCodigo, Descripcion, Tarifa, Imagen FROM TipoVehiculo";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tipoVehiculo = new TipoVehiculo
                        {
                            TVCodigo = reader.GetInt32(0),
                            Descripcion = reader.GetString(1),
                            Tarifa = reader.GetDecimal(2),
                            Imagen = reader.GetString(3)
                        };

                        // Agregar objeto a la colección
                        listaTiposVehiculo.Add(tipoVehiculo);
                    }
                }
            }

            return listaTiposVehiculo;
        }

    }
}
