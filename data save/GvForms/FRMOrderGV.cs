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
    public partial class FRMOrderGV : Form
    {
        public FRMOrderGV()
        {
            InitializeComponent();
            GetOrderData();

        }

        private void GetOrderData()
        {
            GcOrder.DataSource = OrderDal.GetData();
        }

        private void GvOrder_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
