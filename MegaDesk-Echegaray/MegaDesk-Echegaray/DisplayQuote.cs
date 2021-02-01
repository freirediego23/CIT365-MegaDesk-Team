using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Echegaray
{
    public partial class DisplayQuote : Form
    {
 
        public DisplayQuote(string currentDateInfo, string customerInfo, string areaTotal, string drawerTotal, string materialSelected, string materialTotal, string shippingSelected, string shippingTotal, string totalDesk)
        {
            InitializeComponent();
            quoteDate.Text = currentDateInfo;
            custName.Text = customerInfo;
            areaCost.Text = areaTotal;
            drawerCost.Text = drawerTotal;
            materialName.Text = materialSelected;
            materialCost.Text = materialTotal;
            shippingMethod.Text = shippingSelected;
            shippingCost.Text = shippingTotal;
            totalCost.Text = totalDesk;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            Close();
        }
    }
}
