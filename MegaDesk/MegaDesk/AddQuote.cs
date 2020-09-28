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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            cbSurfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            cbSurfaceMaterial.SelectedItem = SurfaceMaterial.Laminate;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            StreamReader reader = new StreamReader("test.txt");

            while (reader.EndOfStream == false) {
                string line = reader.ReadLine();
                rtDetails.Text = line;
            }
            reader.Close();
        }
    }
}
