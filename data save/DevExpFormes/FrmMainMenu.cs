using data_save.GvForms;
using data_save.SousFormes;
using System.Windows.Forms;

namespace data_save.DevExpFormes
{
    public partial class FrmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        
       
        
        private void BtnShowClientTb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FRMClientGV gvC = new FRMClientGV();
            //    gvC.MdiParent = this;
            //    gvC.Show();

            
            FRMClientGV accounts = Application.OpenForms["FRMClientGV"] as FRMClientGV;
            if (accounts != null)
            {
                accounts.WindowState = FormWindowState.Normal;
                accounts.BringToFront();
                accounts.Activate();
            }
            else
            {
                accounts = new FRMClientGV();
                accounts.MdiParent = this;
                accounts.Show();
            }

        }
       

        private void BtnNewClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeClientForm client = new DeClientForm();
            client.Show();
        }

        private void BtnRefreshC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FRMClientGV Gvc = new FRMClientGV();
            //Gvc.GCClient.DataSource = PersonneDAL.getData();

            FRMClientGV accounts = Application.OpenForms["FRMClientGV"] as FRMClientGV;
            if (accounts != null)
            {                                             
                accounts.GCClient.DataSource = PersonneDAL.getData();
            }
           


        }

        private void BtnShowProduitTb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FRMProductGV gvP = new FRMProductGV();

            //gvP.MdiParent = this;
            //gvP.Show();
            FRMProductGV accounts = Application.OpenForms["FRMProductGV"] as FRMProductGV;
            if (accounts != null)
            {
                accounts.WindowState = FormWindowState.Normal;
                accounts.BringToFront();
                accounts.Activate();
                accounts.GCproduct.DataSource = ProductDAL.ProData();
            }
            else
            {
                accounts = new FRMProductGV();
                accounts.MdiParent = this;
                accounts.Show();

            }
        }

        private void BtnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewProductForm Product = new NewProductForm();
            Product.Show();
        }

        private void BtnRefreshP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FRMProductGV accounts = Application.OpenForms["FRMProductGV"] as FRMProductGV;
            if (accounts != null)
            {
                accounts.GCproduct.DataSource = ProductDAL.ProData();
            }

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNewOrder Order = new FrmNewOrder();
            Order.Show();
        }

        private void BtnShowOrdersTb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FRMOrderGV Gvo = new FRMOrderGV();
            //Gvo.MdiParent = this;
            //Gvo.Show();


            FRMOrderGV FrmGV = Application.OpenForms["FRMOrderGV"] as FRMOrderGV;
            if (FrmGV != null)
            {
                FrmGV.WindowState = FormWindowState.Normal;
                FrmGV.BringToFront();
                FrmGV.Activate();
                FrmGV.GcOrder.DataSource = OrderDal.GetData();
            }
            else
            {
                FrmGV = new FRMOrderGV();
                FrmGV.MdiParent = this;
                FrmGV.Show();

            }
        }
    }
}