using System;
using System.Data;
using System.Windows.Forms;


namespace data_save.SousFormes
{
    public partial class ClientModifieForm : Form
    {

       


        public ClientModifieForm()
        {
            InitializeComponent();
            GetData();
        }

        private void getClientData()
        {

           
            
        }

        PersonneDAL pDL = new PersonneDAL();
        Personne p = new Personne();
        public int ID;
        

        public void GetData()
        {
            //DataTable dtClient = PersonneDAL.getData();
            //Ordergridvew.DataSource = OrderDal.GetData();
            
            

            //CbClient.DataSource = dtClient;
            //CbClient.DisplayMember = "Name";
            //CbClient.ValueMember = "IdClient";
        }

        private void ShowData()
        {
            //p.dataId = Convert.ToInt32(ID);
            //pDL.Getdata(p);


            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            //MessageBox.Show(String.Format("the selected row is {0} name {1}", CbClient.SelectedValue, CbClient.Text));
            //ID = CbClient.SelectedValue.ToString();

            
            


        }

     

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {






            p.dataId = ID;
            p.Addresse = TxtAddresse.Text;
            p.LastName = TxtLasteName.Text;
            p.Name = TxtName.Text;
            p.NumPhone = Convert.ToInt32(TxtNumPhone.Text);

            pDL.updatePerson(p);
            MessageBox.Show("new data Updated", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTsave.Enabled = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
