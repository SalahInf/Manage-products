using data_save.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_save.DALclasses
{
    class OrderDetailDAL
    {
        static SqlConnection con = ConnexionDb.GetConexionDb();










        public void getId(OrderDtata oSD)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(IdOrder as int)),0) +1 from Order_Db ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oSD.O_OrderId = Convert.ToInt32(dt.Rows[0][0]);
        }




        public void save(OrderDtata oSD)
        {


            if (con.State == ConnectionState.Closed)
                con.Open();



            string query = "INSERT INTO Order_Db(IdProduct,IdClient,OrderDate,StatuedeCommand) VALUES ('" + oSD.O_ProductId + "','" + oSD.O_ClientId + "','" + oSD.O_Date + "','" + oSD.O_StatuedeCommand + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();


        }

















    }
}
