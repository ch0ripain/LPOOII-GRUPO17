using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                string query = "SELECT SectorCodigo, Descripcion, Identificador, Habilitado FROM Sector WHERE SectorCodigo = @Codigo";
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
                                Habilitado = reader.GetBoolean(3)
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


    }
}
