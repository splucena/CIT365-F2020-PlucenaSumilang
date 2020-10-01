using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote() 
        {
            InitializeComponent();
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            this.Text = $"{AddQuote.customerName} - {AddQuote.dateCreated}";
            lblDate.Text = AddQuote.dateCreated;
            lblCustomerName.Text = AddQuote.customerName;
            lblTotalSizeIn.Text = AddQuote.totalSize;
            lblSizeCost.Text = AddQuote.sizeCost;
            lblDrawerCost.Text = AddQuote.drawerCost;
            lblMaterial.Text = AddQuote.material;
            lblMaterialCost.Text = AddQuote.materialCost;
            lblShippingMethod.Text = AddQuote.shippingMethod;
            lblShippingCost.Text = AddQuote.shippingCost;
            lblTotalCost.Text = AddQuote.totalCost;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
