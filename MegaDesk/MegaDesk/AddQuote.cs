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
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine,
    };
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();             
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            cbSurfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            cbSurfaceMaterial.SelectedItem = SurfaceMaterial.Laminate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            writer = new StreamWriter("test.txt");

            writer.WriteLine("hello");
            writer.Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            //StreamReader reader = new StreamReader("test.txt");

            //while (reader.EndOfStream == false) {
            //    string line = reader.ReadLine();
            //    rtDetails.Text = line;
            //}
            //reader.Close();

            decimal width = decimal.Parse(txtWidth.Text);
            decimal depth = decimal.Parse(txtDepth.Text);
            int numberOfDrawer = int.Parse(cbNoOfDrawers.Text);
            int rushOptionDays = int.Parse(cbOrderOptions.Text);
            string surfaceMaterial = cbSurfaceMaterial.Text;

            // Crete desk
            Desk d = new Desk(width, depth, numberOfDrawer, surfaceMaterial, rushOptionDays); 
            
            // Quote details
            // Customer name
            lblCustomerName.Text = txtName.Text;

            // Desk details
            lblBasePrice.Text = "200.00";
            lblBaseSizeIncluded.Text = "1000.00";
            lblCostPerIn.Text = "1.00";
            lblTotalSizeIn.Text = $"{Math.Round(d.computeSurfaceArea(width, depth), 2)}";
            lblSizeCost.Text = Math.Round(d.computeDeskSizeCost(), 2).ToString("F");

            // Drawer
            lblPricePerDrawer.Text = "50.00";
            lblDrawerCost.Text = Math.Round(d.computeDrawerCost(), 2).ToString("F");

            // Surface material
            lblMaterial.Text = surfaceMaterial;
            lblMaterialCost.Text = Math.Round(d.computeSurfaceMaterialCost(), 2).ToString("F");

            // Shipping details
            string shippingMethod = null;
            if (rushOptionDays != 14)
            {
                shippingMethod = $"Rush - {rushOptionDays} Days";
            } else
            {
                shippingMethod = $"Normal - {rushOptionDays} Days";
            }
            lblShippingMethod.Text = shippingMethod;
            lblShippingCost.Text = Math.Round(d.computeShippingCost(), 2).ToString("F");

            // Total cost
            lblTotalCost.Text = Math.Round(d.computeDeskPrice(), 2).ToString("F");

            // Create DeskQuote
            DeskQuote dq = new DeskQuote(d, Convert.ToDateTime(dtDateCreated.Value), txtName.Text);
            dq.saveDeskQuote(dq);
            dq.displayDeskQuotes();
        }
    }
}
