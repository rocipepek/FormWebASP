using System.Data.SqlClient;

namespace Datos
{
    class BdComun
    {
        public static SqlConnection EstablecerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=ROCIO\\ROCIO;Initial Catalog=Taller;Integrated Security=true;");
            conectar.Open();
            return conectar;
        }

    }
}
