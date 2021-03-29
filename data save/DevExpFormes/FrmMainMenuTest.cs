using data_save.GvForms;
using data_save.SousFormes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_save.DevExpFormes
{
    public partial class FrmMainMenuTest : Form
    {
        public FrmMainMenuTest()
        {
            InitializeComponent();
        }


        //PersonneDAL pDAL = new PersonneDAL();
        //Personne p = new Personne();
        ////Product
        //ProductsSave pSD = new ProductsSave();
        //ProductDAL Pro = new ProductDAL();

        private void fichClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMClientGV gvC = new FRMClientGV();

            gvC.MdiParent = this;
            gvC.Show();
        }

        private void fichProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMProductGV gvP = new FRMProductGV();

            gvP.MdiParent = this;
            gvP.Show();
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeClientForm client = new DeClientForm();
            client.Show();
        }

        private void nouveauProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductForm Product = new NewProductForm();
            Product.Show();
        }
    }
}
