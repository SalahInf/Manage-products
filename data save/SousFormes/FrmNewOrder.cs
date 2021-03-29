using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_save.SousFormes
{
    public partial class FrmNewOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OrderDtata oSD = new OrderDtata();
        OrderDal oRD = new OrderDal();
        ProductDAL pDal = new ProductDAL();
        ProductsSave pSD = new ProductsSave();

        public FrmNewOrder()
        {
            InitializeComponent();

            //Get The Id To save
            oRD.getId(oSD);
            TxtNumCommande.Text = oSD.O_OrderId.ToString();
            //

            getData();
            
        }

        public  FrmNewOrder(DataRow Dv)
        {
            InitializeComponent();
            ShowClientData(Dv);
        }

        // client Get Data from Grid view


        public int ID;

            private void ShowClientData(DataRow Dv)
            {
                ID = Convert.ToInt32(Dv["IdClient"]);           
                TxtClientName.Text = Dv["Name"].ToString();
                TxtClientNumber.Text = Dv["number"].ToString();
                TxtClientPrenom.Text = Dv["City"].ToString();

            }





        public void getData()
        {
            DataTable dtClient = PersonneDAL.getData();
            DataTable dtProduit = ProductDAL.ProData();
            DataTable dtOrder = OrderDal.GetData();

            
            //COMBO BOX CLIENT
            CbClient.DataSource = dtClient;
            CbClient.DisplayMember = "Name";
            CbClient.ValueMember = "IdClient";

            //COMBO BOX PRODUCT 
            CbProduit.DataSource = dtProduit;
            CbProduit.DisplayMember = "PName";
            CbProduit.ValueMember = "IdProduct";



        }


        private void CbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            String.Format("the selected row is {0} name {1}", CbClient.SelectedValue, CbClient.Text);
            if (CbClient.SelectedValue is int)
            {
                oSD.O_ClientId = Convert.ToInt32(CbClient.SelectedValue);
                TxtClientName.Text = CbClient.Text.ToString();
            }


        }
        
        private void CbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {


            
            String.Format("the selected row is {0} name {1}", CbProduit.SelectedValue, CbProduit.Text);
            if(CbProduit.SelectedValue is int)
            {
                oSD.O_ProductId = Convert.ToInt32(CbProduit.SelectedValue);
                TxtProduitName.Text = CbProduit.Text.ToString();

                pDal.ShowProductDtata(oSD);


                TxtPrixProduit.Text = pSD.P_Price.ToString();
                TxtStockPeoduit.Text = pSD.P_Stock.ToString();
                TxtEtatProduit.Text = pSD.P_Etat.ToString();


            }
            
            
        }

        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void BtSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSD.O_StatuedeCommand = CbStatueProduit.Text;
            oSD.O_Date = DtpCommande.Value.Date.ToString("yyyyMMdd");
            OrderDal oDal = new OrderDal();

            oDal.save(oSD);
            MessageBox.Show("save", "Nouveau commende sauvgarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtSave.Enabled = false;
        }
    }
}
