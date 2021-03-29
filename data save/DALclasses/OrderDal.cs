using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using data_save.Conexion;
using System.Data.OleDb;

namespace data_save
{
    class OrderDal
    {
        //static SqlConnection con = new SqlConnection(@"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True");

        static SqlConnection con = ConnexionDb.GetConexionDb();


        public static DataTable GetData()
        {
            SqlCommand cmd = new SqlCommand("select Order_Db.*,Client_Db .Name,Product_Db.PName from Order_Db inner join Client_Db on Order_Db.IdClient=Client_Db .IdClient inner join Product_Db on Order_Db.IdProduct=Product_Db.IdProduct", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }

        public static DataTable ShowClientInf(OrderDtata oSD)
        {

            return PersonneDAL.ShowClientInf(oSD);

        }
        public static DataTable ShowProductInfo(OrderDtata oSD)
        {
            return ProductDAL.ShowProductInfo(oSD);

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


        public void getId(OrderDtata oSD)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(IdOrder as int)),0) +1 from Order_Db ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oSD.O_OrderId = Convert.ToInt32(dt.Rows[0][0]);
        }

         

    }
}
