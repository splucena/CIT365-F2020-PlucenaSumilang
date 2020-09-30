namespace MegaDesk
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvQuotes = new System.Windows.Forms.ListView();
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drawerCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shippingMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shippingCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvQuotes);
            this.groupBox1.Location = new System.Drawing.Point(23, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(577, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Quotes";
            // 
            // lvQuotes
            // 
            this.lvQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerName,
            this.dateCreated,
            this.surfaceArea,
            this.sizeCost,
            this.drawerCost,
            this.material,
            this.materialCost,
            this.shippingMethod,
            this.shippingCost,
            this.totalCost});
            this.lvQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQuotes.FullRowSelect = true;
            this.lvQuotes.GridLines = true;
            this.lvQuotes.HideSelection = false;
            this.lvQuotes.Location = new System.Drawing.Point(8, 21);
            this.lvQuotes.Name = "lvQuotes";
            this.lvQuotes.Size = new System.Drawing.Size(561, 441);
            this.lvQuotes.TabIndex = 0;
            this.lvQuotes.UseCompatibleStateImageBehavior = false;
            // 
            // customerName
            // 
            this.customerName.Text = "Customer Name";
            // 
            // dateCreated
            // 
            this.dateCreated.Text = "Date Created";
            // 
            // surfaceArea
            // 
            this.surfaceArea.Text = "Surface Area";
            // 
            // sizeCost
            // 
            this.sizeCost.Text = "Size Cost";
            // 
            // drawerCost
            // 
            this.drawerCost.Text = "Drawer Cost";
            // 
            // material
            // 
            this.material.Text = "Material";
            // 
            // materialCost
            // 
            this.materialCost.Text = "Material Cost";
            // 
            // shippingMethod
            // 
            this.shippingMethod.Text = "Shipping Method";
            // 
            // shippingCost
            // 
            this.shippingCost.Text = "Shipping Cost";
            // 
            // totalCost
            // 
            this.totalCost.Text = "Total Cost";
            // 
            // cbSurfaceMaterial
            // 
            this.cbSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbSurfaceMaterial.FormattingEnabled = true;
            this.cbSurfaceMaterial.Location = new System.Drawing.Point(350, 8);
            this.cbSurfaceMaterial.Margin = new System.Windows.Forms.Padding(8);
            this.cbSurfaceMaterial.Name = "cbSurfaceMaterial";
            this.cbSurfaceMaterial.Size = new System.Drawing.Size(242, 25);
            this.cbSurfaceMaterial.TabIndex = 5;
            this.cbSurfaceMaterial.SelectedValueChanged += new System.EventHandler(this.cbSurfaceMaterial_SelectedValueChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.cbSurfaceMaterial);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvQuotes;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader dateCreated;
        private System.Windows.Forms.ColumnHeader surfaceArea;
        private System.Windows.Forms.ColumnHeader sizeCost;
        private System.Windows.Forms.ColumnHeader drawerCost;
        private System.Windows.Forms.ColumnHeader material;
        private System.Windows.Forms.ColumnHeader materialCost;
        private System.Windows.Forms.ColumnHeader shippingMethod;
        private System.Windows.Forms.ColumnHeader shippingCost;
        private System.Windows.Forms.ColumnHeader totalCost;
        private System.Windows.Forms.ComboBox cbSurfaceMaterial;
    }
}