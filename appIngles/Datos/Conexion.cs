using System.Data.SqlClient;

namespace appIngles.Datos
{
    public class Conexion
    {

        SqlConnection conex;
        IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

        public SqlConnection Conectar()
        {
            conex = new SqlConnection(configuration["ConnectionStrings:DefaultConnection"]);
            conex.Open();
            return conex;

        }
    }
}
