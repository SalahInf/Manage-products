using data_save.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_save
{

    public class PersonneDAL  
    {
        //static SqlConnection con = new SqlConnection(@"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True");
        static SqlConnection con = ConnexionDb.GetConexionDb();
        public static DataTable  getData()
        {
            SqlCommand cmd = new SqlCommand("select * from Client_Db", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }
         

        public void updatePerson(Personne p)
        {

            con.Open();
            string query = "UPDATE Client_Db SET Name='" + p.Name + "',City='" + p.LastName + "',number='" + p.NumPhone + "',Addresse='" + p.Addresse + "'  WHERE IdClient ='" + p.dataId + "'";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        public void savePersonne(Personne p)
        {
            con.Open();
            string query = "INSERT INTO Client_Db(Name,City,number,Addresse) VALUES ('" + p.Name + "','" + p.LastName + "','" + p.NumPhone + "','"+ p.Addresse + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    

        public void DeletePerson(Personne p)
        {
            con.Open();
            string query = "DELETE FROM Client_Db where IdClient = '" + p.dataId+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            
        }


        public static DataTable ShowClientInf(OrderDtata oSD)
        {



            SqlCommand cmd = new SqlCommand("select * from Client_Db Where IdClient='" + oSD.O_ClientId + "'", con);
            

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;



        }
          

        public void Getdata(Personne p)
        {
            SqlCommand cmd = new SqlCommand("select * from Client_Db Where IdClient='" + p.dataId + "'", con);


            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();


        }

        public void ChechId(Personne p)
        {
            using (var cmd = new SqlCommand("select 1 from Client_Db where IdClient='" + p.dataId + "'", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@IdClient", p.dataId);
                using (var dr = cmd.ExecuteReader())
                {
                   
                    if (dr.HasRows)
                    {
                        con.Close();
                        updatePerson(p);
                        MessageBox.Show("Les Cordoner ", " UPdated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        con.Close();
                        savePersonne(p);
                        MessageBox.Show("Nouveau client", "sauvgarder ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }




    }

}

