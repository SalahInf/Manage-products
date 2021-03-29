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

namespace data_save.GvForms
{
    public partial class FRMProductGV : Form
    {

        ProductDAL Pro = new ProductDAL();
      

        public FRMProductGV()
        {
            InitializeComponent();
            getProductData();
        }



        private void getProductData()
        {
            GCproduct.DataSource = ProductDAL.ProData();
        }

        private void GVprodcut_DoubleClick(object sender, EventArgs e)
        {
            //DataRow Dv = GVprodcut.GetFocusedDataRow();

            NewProductForm F = new NewProductForm();
            F.Show();
        }
    }
}
