using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            lvQuotes.View = View.Details;

            // Read content of file storage
            string[] lines = File.ReadAllLines(@"qoutes.txt");
            foreach (string line in lines)
            {
                //string[] quote = line.Split(new string[] { "," }, StringSplitOptions.None);
                string[] quote = line.Split(',');
                lvQuotes.Items.Add(new ListViewItem(quote));
            }
        }

        private void lvQuotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuotes.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvQuotes.SelectedItems[0];
                lblCustomerName.Text = lv.SubItems[0].Text;
                // Date

                // Desk details
                lblBasePrice.Text = "200.00";
                lblBaseSizeIncluded.Text = "1000.00";
                lblCostPerIn.Text = "1.00";

                // Surface area
                lblTotalSizeIn.Text = lv.SubItems[2].Text;
                lblSizeCost.Text = lv.SubItems[3].Text;

                // Drawer
                lblPricePerDrawer.Text = "50.00";
                lblDrawerCost.Text = lv.SubItems[4].Text;

                // Material
                lblMaterial.Text = lv.SubItems[5].Text;
                lblMaterialCost.Text = lv.SubItems[6].Text;

                // Shipping
                lblShippingMethod.Text = lv.SubItems[7].Text;
                lblShippingCost.Text = lv.SubItems[8].Text;

                // Total cost
                lblTotalCost.Text = lv.SubItems[9].Text;
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //ViewAllQuotes v = new ViewAllQuotes();
            //v.Close();
            this.Close();
        }
    }
}
