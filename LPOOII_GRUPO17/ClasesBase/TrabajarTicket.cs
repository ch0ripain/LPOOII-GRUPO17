using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
