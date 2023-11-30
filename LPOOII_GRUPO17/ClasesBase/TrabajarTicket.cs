using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarTicket
    {
        public static void AgregarTicket(Ticket ticket)
        {
            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

                // Sentencia SQL
                string consulta = "INSERT INTO Ticket(FechaHoraEnt,FechaHoraSal,ClienteDNI,TVCodigo,Patente,SectorCodigo,Duracion,Tarifa,Total) values (@fechaHoraEnt,@fechaHoraSal,@clienteDNI,@tvCodigo,@patente,@sectorCodigo,@duracion,@tarifa,@total)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@fechaHoraEnt", ticket.FechaHoraEnt);
                    cmd.Parameters.AddWithValue("@fechaHoraSal", ticket.FechaHoraSal);
                    cmd.Parameters.AddWithValue("@clienteDNI", ticket.ClienteDNI);
                    cmd.Parameters.AddWithValue("@tvCodigo", ticket.TVCodigo);
                    cmd.Parameters.AddWithValue("@patente", ticket.Patente);
                    cmd.Parameters.AddWithValue("@sectorCodigo", ticket.SectorCodigo);
                    cmd.Parameters.AddWithValue("@duracion", ticket.Duracion);
                    cmd.Parameters.AddWithValue("@tarifa", ticket.Tarifa);
                    cmd.Parameters.AddWithValue("@total", ticket.Total);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Ticket RecuperarTicketGenerado()
        {
            // Ticket para almacenar el resultado
            Ticket ticket = null;

            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

                // Sentencia SQL para recuperar el último registro de la tabla
                string consulta = "SELECT TOP 1 * FROM Ticket ORDER BY TicketNro DESC";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crear un objeto Ticket con los datos del registro
                            ticket = new Ticket
                            {
                                TicketNro = reader.GetInt32(0),
                                FechaHoraEnt = reader.GetDateTime(1),
                                FechaHoraSal = reader.GetDateTime(2),
                                ClienteDNI = reader.GetInt32(3),
                                TVCodigo = reader.GetInt32(4),
                                Patente = reader.GetString(5),
                                SectorCodigo = reader.GetInt32(6),
                                Duracion = reader.GetDecimal(7),
                                Tarifa = reader.GetDecimal(8),
                                Total = reader.GetDecimal(9)
                            };
                        }
                    }
                }
            }

            return ticket;
        }

        public static Ticket RecuperarTicketPorSectorCodigo(int codigoSector)
        {
            // Ticket para almacenar el resultado
            Ticket ticket = null;

            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

                // Sentencia SQL para recuperar el ticket con el SectorCodigo proporcionado
                string consulta = "SELECT TOP 1 * FROM Ticket WHERE SectorCodigo = @CodigoSector ORDER BY TicketNro DESC";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@CodigoSector", codigoSector);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crear un objeto Ticket con los datos del registro
                            ticket = new Ticket
                            {
                                TicketNro = reader.GetInt32(0),
                                FechaHoraEnt = reader.GetDateTime(1),
                                FechaHoraSal = reader.GetDateTime(2),
                                ClienteDNI = reader.GetInt32(3),
                                TVCodigo = reader.GetInt32(4),
                                Patente = reader.GetString(5),
                                SectorCodigo = reader.GetInt32(6),
                                Duracion = reader.GetDecimal(7),
                                Tarifa = reader.GetDecimal(8),
                                Total = reader.GetDecimal(9)
                            };
                        }
                    }
                }
            }

            return ticket;
        }

        public static void ActualizarTicket(DateTime fechaSalida, decimal duracion, decimal total, int ticketId)
        {
            using (SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                conexion.Open();

                string consulta = "UPDATE Ticket SET FechaHoraSal = @fechaSalida, Duracion = @duracion, Total = @total WHERE TicketNro = @ticketId";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static ObservableCollection<VentaTicket> TraerVentas()
        {
            ObservableCollection<VentaTicket> listaVentas = new ObservableCollection<VentaTicket>();
            VentaTicket ventaTicket = null;
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();
                string query = "SELECT t.TicketNro, t.FechaHoraEnt, t.FechaHoraSal, t.ClienteDNI, c.Apellido, c.Nombre, c.Telefono, t.TVCodigo, v.Descripcion, v.Tarifa, t.Patente, t.SectorCodigo, s.Descripcion, s.Identificador, s.TiempoDisponible, t.Duracion, t.Tarifa, t.Total " +
                                "FROM Ticket t " +
                                "JOIN Cliente c ON t.ClienteDNI = c.ClienteDNI " +
                                "JOIN TipoVehiculo v ON t.TVCodigo = v.TVCodigo " +
                                "JOIN Sector s ON t.SectorCodigo = s.SectorCodigo " +
                                "WHERE t.Duracion > 0";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                         ventaTicket = new VentaTicket
                        {
                            TicketNro = reader.GetInt32(0),
                            FechaHoraEnt = reader.GetDateTime(1),
                            FechaHoraSal = reader.GetDateTime(2),
                            ClienteDNI = reader.GetInt32(3),
                            AyN = reader.GetString(4) + ", " + reader.GetString(5),
                            Telefono = reader.GetString(6),
                            TVCodigo = reader.GetInt32(7),
                            TipoVehiculo = reader.GetString(8),
                            Tarifa = reader.GetDecimal(9),
                            Patente = reader.GetString(10),
                            SectorCodigo = reader.GetInt32(11),
                            SectorDescripcion = reader.GetString(12),
                            SectorIdentificador = reader.GetString(13),
                            TiempoDisponible = reader.GetDateTime(14),
                            Duracion = (int)Math.Ceiling(reader.GetDecimal(15)) + " minutos",
                            TarifaTicket = reader.GetDecimal(16),
                            Total = reader.GetDecimal(17)
                        };

                        // Agregar objeto a la colección
                        listaVentas.Add(ventaTicket);

                    }
                }
            }

            return listaVentas;
        }

        public static decimal ObtenerTotalVentasXRango(DateTime desde, DateTime hasta)
        {
            decimal totalVentas = 0;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
            {
                cn.Open();

                string query = "SELECT ISNULL(SUM(Total), 0) " +
                               "FROM Ticket " +
                               "WHERE FechaHoraEnt BETWEEN @desde AND @hasta AND Duracion > 0";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    totalVentas = (decimal)cmd.ExecuteScalar();
                }
            }

            return totalVentas;
        }


    }
}
