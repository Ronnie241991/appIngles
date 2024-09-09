using appIngles.Datos;
using appIngles.Models;
using System.Data;
using System.Data.SqlClient;

namespace appIngles.Negocio
{
    public class Palabras:Conexion
    {


        bool seguir;
        int filaAfectadas;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dre;
        Palabra item;
        string mensaje = string.Empty;

        public bool Buscar(int idUsuario, ref List<Palabra> lisPalabra, ref string codError, ref string menError)
        {
            seguir = false;
            con = new SqlConnection();


            try
            {
                con = Conectar();

                cmd = new SqlCommand("sp_PalabraBuscar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.Add(new SqlParameter("@codError", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new SqlParameter("@menError", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output });

                dre = cmd.ExecuteReader();

                while (dre.Read())
                {
                    item = new Palabra();
                    item.idPalabra = Convert.ToInt32(dre["idPalabra"].ToString());
                    item.espaniol = dre["espaniol"].ToString();
                    item.ingles = dre["ingles"].ToString();
                    item.inglesPro = dre["inglesPro"].ToString();
                    item.presente = dre["presente"].ToString();
                    item.presentePro = dre["presentePro"].ToString();
                    item.gerundio = dre["gerundio"].ToString();
                    item.gerundioPro = dre["gerundioPro"].ToString();
                    item.pasado = dre["pasado"].ToString();
                    item.pasadoPro = dre["pasadoPro"].ToString();
                    item.fechaRegistro = Convert.ToDateTime(dre["fechaRegistro"].ToString());
                    item.fechaModificacion = Convert.ToDateTime(dre["fechaModificacion"].ToString());

                    lisPalabra.Add(item);

                }

                dre.Close();

                codError = cmd.Parameters["@codError"].Value.ToString();
                menError = cmd.Parameters["@menError"].Value.ToString();

                if (mensaje.Trim() == string.Empty)
                {
                    seguir = true;
                }



            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                    con.Dispose();

                con.Close();

            }

            return seguir;

        }
    }
}
