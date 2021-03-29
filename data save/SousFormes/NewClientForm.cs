using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

 namespace data_save.SousFormes
{
    public partial class DeClientForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        
        public DeClientForm()
        {
            InitializeComponent();

        }
        public DeClientForm(DataRow Dv)
        {
            InitializeComponent();
            ShowData(Dv);

        }
        Personne p = new Personne();
        PersonneDAL pDAL = new PersonneDAL();
        public int ID;

        private void ShowData(DataRow Dv )
        {
            ID = Convert.ToInt32(Dv["IdClient"]);
            TxtAdresse.Text = Dv["Addresse"].ToString();
            TxtName.Text = Dv["Name"].ToString();
            TxtTele.Text = Dv["number"].ToString();
            TxtPrenom.Text = Dv["City"].ToString();

        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            p.dataId = ID;
            p.Name = TxtName.Text;
            p.LastName = TxtPrenom.Text;
            p.NumPhone = Convert.ToInt32(TxtTele.Text);
            p.Addresse = TxtAdresse.Text;
            pDAL.ChechId(p);
            bbiSave.Enabled = false;
            //pDAL.savePersonne(p);
            //MessageBox.Show("new data saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //bbiSave.Enabled = false;

        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //pDAL.Getdata(p);
            //TxtAdresse.Text = p.Addresse.ToString();
            //TxtName.Text = p.Name.ToString();
            //TxtPrenom.Text = p.LastName.ToString();
            //TxtTele.Text = p.NumPhone.ToString();
        }
    }
}
