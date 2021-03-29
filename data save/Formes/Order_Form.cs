using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data_save
{
    public partial class Selling_Form : Form
    {

        OrderDtata oSD = new OrderDtata();
        OrderDal oRD = new OrderDal();
        ProductDAL pD = new ProductDAL();



        public Selling_Form()
        {
            InitializeComponent();
            getData();

            //productinf_Grid.DataSource = pD.ProData();

        }


        public void getData()
        {
            DataTable dtClient = PersonneDAL.getData ();
            Ordergridvew.DataSource = OrderDal.GetData();

            
            cbClient.DataSource = dtClient;
            cbClient.DisplayMember = "Name";
            cbClient.ValueMember = "IdClient";

            ProductGridview.DataSource = ProductDAL.ProData();
        }

        private void SellingRoom_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'connectionDataSet3.Table_1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            ////this.table_1TableAdapter.Fill(this.connectionDataSet3.Table_1);

        }

        
        private void Sell_Click(object sender, EventArgs e)
        {
            //oSD.O_ClientInf = ClientInf_Box.Text;
            //oSD.O_ProductInf = ProductInf_Box.Text;
            oSD.O_Date = dateTimePicker1.Value.Date.ToString("yyyyMMdd");

            oSD.O_ClientId = Convert.ToInt32(cbClient.SelectedValue);

            oRD.save(oSD);
            MessageBox.Show("new data saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getData();

            
            // SqlConnection con = new SqlConnection(@"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True");

            //if (con.State == ConnectionState.Closed)
            //    con.Open();



            //string query = "INSERT INTO Order_Db(IdProduct,IdClient,OrderDate) VALUES ('" + oSD.O_ProductId + "','" + oSD.O_ClientId + "','" + oSD.O_Date + "')";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //SDA.SelectCommand.ExecuteNonQuery();
            //con.Close();



        }


        private void ProductGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //oSD.O_ProductId = Convert.ToInt32(ProductGridview.SelectedRows[0].Cells[0].Value);
            //ProductInf_Box.Text = ProductGridview.SelectedRows[0].Cells[1].Value.ToString();
        }
       

        

       

        private void ClientGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;

            //DataGridViewRow dr = dgv.Rows[e.RowIndex];
            //dr.DataBoundItem.

            //string name = dgv.Rows[e.RowIndex].Cells[1].Value.ToString(); 

            //oSD.O_ClientId = Convert.ToInt32(ClientGridview.Rows[e.RowIndex].Cells[0].Value);
            //ClientInf_Box.Text = ClientGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        

        private void ClientGridview_DoubleClick(object sender, EventArgs e)
        {
            //DataGridView dgv =(DataGridView) sender;

            //int i = dgv.CurrentCell.RowIndex;
            
            
        }

        //public DataTable data;
        private void Test_Click(object sender, EventArgs e)
        {
            //DataView Dv = new DataView(data);
            //Dv.RowFilter = string.Format("IdProduct LIKE '%{0}%'", oSD.O_ProductId);
            //productinf_Grid.DataSource = Dv;

            //oSD.O_ClientId = Convert.ToInt32(Box_Test);
            //oRD.Sherch(oSD);
            //productinf_Grid.DataSource = pD.ProData();

        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(String.Format("the selected row is {0} name {1}", cbClient.SelectedValue, cbClient.Text));
            String.Format("the selected row is {0} name {1}", cbClient.SelectedValue, cbClient.Text);
            ClientInf_Box.Text = cbClient.SelectedText.ToString();
            
            
        }

        private void ProductGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oSD.O_ProductId = Convert.ToInt32(ProductGridview.Rows[e.RowIndex].Cells[0].Value);
            ProductInf_Box.Text = ProductGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Ordergridvew_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oSD.O_ProductId= Convert.ToInt32(Ordergridvew.Rows[e.RowIndex].Cells[1].Value);
            oSD.O_ClientId = Convert.ToInt32(Ordergridvew.Rows[e.RowIndex].Cells[2].Value);
            clientinf_Grid.DataSource = OrderDal.ShowClientInf(oSD);
            productinf_Grid.DataSource = OrderDal.ShowProductInfo(oSD);

        }

       
    }
}
