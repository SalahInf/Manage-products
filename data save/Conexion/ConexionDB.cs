using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_save.Conexion
{
   public class ConnexionDb
    {
        private string chaine = @"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True";
        public static  SqlConnection con = null;


        public  ConnexionDb()
        {
            con = new SqlConnection(chaine);

        }

        public static SqlConnection GetConexionDb()
        {
            if (con == null)
                new ConnexionDb();

            return con;

        }
    }
}
