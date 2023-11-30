using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarSector
    {
        public static Sector TraerSectorPorCodigo(string codigoSector)
        {
            int codigo;
            if (!int.TryParse(codigoSector, out codigo))
            {
                // La conversión a int no fue exitosa, puedes manejar el error aquí
                return null;
            }

            Sector sector = null;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                string query = "SELECT SectorCodigo, Descripcion, Identificador, Habilitado, TiempoDisponible FROM Sector WHERE SectorCodigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sector = new Sector
                            {
                                SectorCodigo = reader.GetInt32(0),
                                Descripcion = reader.GetString(1),
                                Identificador = reader.GetString(2),
                                Habilitado = reader.GetBoolean(3),
                                TiempoDisponible = reader.GetDateTime(4)
                            };
                        }
                    }
                }
            }

            return sector;
        }

        public static DataTable TraerSectores()
        {
            using (DataTable dt = new DataTable())
            {
                using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT SectorCodigo, Habilitado, Descripcion, Identificador FROM Sector", cn))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public static ObservableCollection<object> TraerSectoresOcupados()
        {
            ObservableCollection<object> listaSectores = new ObservableCollection<object>();

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();
                string query = "SELECT s.SectorCodigo, s.Descripcion, s.Identificador, s.TiempoDisponible, t.ClienteDNI, c.Apellido, c.Nombre, t.TVCodigo, v.Descripcion, t.Patente " +
                               "FROM Sector s " +
                               "JOIN Ticket t ON s.SectorCodigo = t.SectorCodigo " +
                               "JOIN Cliente c ON t.ClienteDNI = c.ClienteDNI " +
                               "JOIN TipoVehiculo v ON t.TVCodigo = v.TVCodigo " +
                               "WHERE s.Habilitado = 0";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sectorTicket = new
                        {
                            SectorCodigo = reader.GetInt32(0),
                            Descripcion = reader.GetString(1),
                            Identificador = reader.GetString(2),
                            TiempoDisponible = reader.GetDateTime(3),
                            ClienteDNI = reader.GetInt32(4),
                            AyN = reader.GetString(5) + ", " + reader.GetString(6),
                            TVCodigo = reader.GetInt32(7),
                            Vehiculo = reader.GetString(8),
                            Patente = reader.GetString(9),
                            Duracion = (int)Math.Floor((DateTime.Now - reader.GetDateTime(3)).TotalMinutes) + " minutos"
                        };

                        // Agregar objeto a la colección
                        listaSectores.Add(sectorTicket);
                    }
                }
            }

            return listaSectores;
        }

        public static void ModificarEstadoSectorNoDisponible(int codigoSector, DateTime nuevoTiempoDisponible)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                string query = "UPDATE Sector SET Habilitado = 0, TiempoDisponible = @NuevoTiempoDisponible WHERE SectorCodigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoSector);
                    cmd.Parameters.AddWithValue("@NuevoTiempoDisponible", nuevoTiempoDisponible);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejar la excepción según sea necesario
                        Console.WriteLine("Error al modificar el estado del sector: " + ex.Message);
                    }
                }
            }
        }

        public static void ModificarEstadoSectorDisponible(int codigoSector, DateTime nuevoTiempoDisponible)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                string query = "UPDATE Sector SET Habilitado = 1, TiempoDisponible = @NuevoTiempoDisponible WHERE SectorCodigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoSector);
                    cmd.Parameters.AddWithValue("@NuevoTiempoDisponible", nuevoTiempoDisponible);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejar la excepción según sea necesario
                        Console.WriteLine("Error al modificar el estado del sector: " + ex.Message);
                    }
                }
            }
        }


    }
}
