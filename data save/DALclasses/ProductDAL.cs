using data_save.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_save
{
    class ProductDAL
    {

       //static SqlConnection con = new SqlConnection(@"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True");
        static SqlConnection con = ConnexionDb.GetConexionDb();

        public static DataTable ProData()
        {
            SqlCommand cmd = new SqlCommand("select * from Product_Db", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }



        
        public void Save(ProductsSave pSD)
        {
            
            if (con.State == ConnectionState.Closed)
                con.Open();



            string query = "INSERT INTO Product_Db(PName,PriceProducts,etat,DateProduct,StockProduct) VALUES ('" + pSD.P_Name + "','" + pSD.P_Price + "','" + pSD.P_Etat + "','" + pSD.P_Date + "','" + pSD.P_Stock + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }


        public void updateProduct(ProductsSave pSD)     
        {

            con.Open();
            string query = "UPDATE  Product_Db SET PName='" + pSD.P_Name + "',PriceProducts='" + pSD.P_Price + "',etat='" + pSD.P_Etat + "',StockProduct='" + pSD.P_Stock + "',DateProduct='" + pSD.P_Date + "'  WHERE IdProduct ='" + pSD.PdataId + "'";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteProduct(ProductsSave pSD)
        {
            con.Open();
            string query = "DELETE FROM Product_Db where IdProduct = '" + pSD.PdataId + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

        }
       



     

        public static DataTable ShowProductInfo(OrderDtata oSD)
        {
            con = ConnexionDb.GetConexionDb();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product_Db Where IdProduct='" + oSD.O_ProductId + "'", con);
            DataTable dt = new DataTable();

        
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }
        // show product info in Order 
        public void ShowProductDtata(OrderDtata oSD)
        {
            ProductsSave pSD = new ProductsSave();
            con = ConnexionDb.GetConexionDb();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product_Db Where IdProduct='" + oSD.O_ProductId + "'", con);
            //DataTable dt = new DataTable();

            SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            if(sdr.Read())
            {
                pSD.P_Etat = (sdr["etat"].ToString());
                pSD.P_Price = (sdr["PriceProducts"].ToString());
                pSD.P_Stock = (Convert.ToInt32(sdr["StockProduct"]));
            }
            con.Close();




        }





    }
}
