using System.Data.SqlClient;

namespace App_Registros.DAO
{
    internal class ConexionBD
    {
        protected SqlConnection Conexion =
            new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; DataBase=Practica_Patrones; Integrated Security=true;");
    }
}
