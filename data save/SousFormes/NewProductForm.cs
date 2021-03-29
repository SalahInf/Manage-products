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
    public partial class NewProductForm : Form
    {

        ProductsSave pSD = new ProductsSave();        
        ProductDAL Pro = new ProductDAL();
        

        public NewProductForm()
        {
            InitializeComponent();
        }

        private void BtSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pSD.P_Price = TxtPrice.Text;
            pSD.P_Stock = Convert.ToInt32(TxtStock.Text);
            pSD.P_Name = TxtNomProduct.Text;
            pSD.P_Etat = CBProductEtat.Text;
            pSD.P_Date = DtProductDate.Value.Date.ToString("yyyyMMdd");
            
            Pro.Save(pSD);
            MessageBox.Show("new data saved", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtSave.Enabled = false;
        }
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
