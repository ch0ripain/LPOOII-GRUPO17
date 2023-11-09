using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT TVCodigo, Descripcion, Tarifa FROM TipoVehiculo", cn))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            
        }

                    public static TipoVehiculo TraerTipoVehiculoPorCodigo(string codigoTipoVehiculo)
                    {
                        int codigo;
                         if (!int.TryParse(codigoTipoVehiculo, out codigo))
                         {
                           // La conversión a int no fue exitosa, puedes manejar el error aquí
                         return null;
                         }

                         TipoVehiculo tipoVehiculo = null;

                         using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString))
                         {
                           string query = "SELECT TVCodigo, Descripcion, Tarifa FROM TipoVehiculo WHERE TVCodigo = @Codigo";
                             using (SqlCommand cmd = new SqlCommand(query, cn))
                             {
                               cmd.Parameters.AddWithValue("@Codigo", codigo);
                               cn.Open();

                              using (SqlDataReader reader = cmd.ExecuteReader())
                              {
                               if (reader.Read())
                                  {
                                   tipoVehiculo = new TipoVehiculo
                                     {
                                      TVCodigo = reader.GetInt32(0),
                                      Descripcion = reader.GetString(1),
                                      Tarifa = reader.GetDecimal(2)
                                     };
                                  }
                              }
                            }
                        }

                        return tipoVehiculo;
                    }



    }
}
