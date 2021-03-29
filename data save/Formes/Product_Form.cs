using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Product_Form : Form
    {

        ProductsSave pSD = new ProductsSave();
        Personne p = new Personne();
        ProductDAL Pro = new ProductDAL();

        

        
        

        public Product_Form()
        {
            InitializeComponent();

            GetData();
            //Pro.RefreshImageGrid();


        }

        private void GetData()
        {
           
                
                GridViewProduits.DataSource = ProductDAL.ProData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=connection;Integrated Security=True");



            pSD.P_Price = txtPPrice.Text;
            pSD.P_Stock = Convert.ToInt32(txtStock.Text);
            pSD.P_Name = txtPName.Text;
            pSD.P_Etat = ComPEtat.Text;
            pSD.P_Date = DateP.Value.Date.ToString("yyyyMMdd");
            //pSD.TheImage = PicP.Image;
            //pSD.P_img = new ImageConverter().ConvertTo(PicP.Image, typeof(Byte[]));



            Pro.Save(pSD);
            MessageBox.Show("new data saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetData();
 

        }

        
        private void GridViewProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {



          

        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            
            // TODO: cette ligne de code charge les données dans la table 'connectionDataSet2.OrdersDB'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ordersDBTableAdapter.Fill(this.connectionDataSet2.OrdersDB);
            // TODO: cette ligne de code charge les données dans la table 'connectionDataSet.Table_1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.table_1TableAdapter.Fill(this.connectionDataSet.Table_1);
            GetData();


            //DataGridViewImageColumn proImage = new DataGridViewImageColumn();
            //proImage.HeaderText = "Image";
            //proImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //DataGridViewTextBoxColumn ProId = new DataGridViewTextBoxColumn();
            //ProId.HeaderText = "id";

            //GridViewProduits.Columns.Add(proImage);
            //GridViewProduits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //GridViewProduits.RowTemplate.Height = 120;
            //GridViewProduits.AllowUserToAddRows = false;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            pSD.P_Price = txtPPrice.Text;
            pSD.P_Stock = Convert.ToInt32(txtStock.Text);
            pSD.P_Name = txtPName.Text;
            pSD.P_Etat = ComPEtat.Text;
            pSD.P_Date = DateP.Value.Date.ToString("yyyyMMdd");

            Pro.updateProduct(pSD);
            MessageBox.Show("new data saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetData();

        }
        
        private void LoadImg_Click(object sender, EventArgs e)
        {

            //OpenFileDialog oFd = new OpenFileDialog();
            //oFd.Filter = "Image(-jpg,.png)|*.png;*.jpg";
            //if (oFd.ShowDialog() == DialogResult.OK)
            //{

            //    pSD.FilePath = oFd.FileName;
            //    PicP.Image = new Bitmap(pSD.FilePath);


            //}
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {

            Pro.DeleteProduct(pSD);
                ProductDAL.ProData();
                MessageBox.Show("Done", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void Reresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void Selling_Click(object sender, EventArgs e)
        {
            Selling_Form Sell = new Selling_Form();
            Sell.Show();
        }

        private void GridViewProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pSD.PdataId = Convert.ToInt32(GridViewProduits.Rows[e.RowIndex].Cells[0].Value);
            txtPName.Text = GridViewProduits.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPPrice.Text = GridViewProduits.Rows[e.RowIndex].Cells[2].Value.ToString();
            ComPEtat.Text = GridViewProduits.Rows[e.RowIndex].Cells[3].Value.ToString();
            DateP.Text = GridViewProduits.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStock.Text = GridViewProduits.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClientForm_Click(object sender, EventArgs e)
        {
            //Client_Form client = new Client_Form();
            //client.Show();
        }
    }
}
