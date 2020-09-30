using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        private Desk _desk;
        private DateTime _shippingDate;
        private String _customerName;

        private List<DeskQuote> _dq;

        public DeskQuote(Desk desk, DateTime shippingDate, String customerName)
        {
            _desk = desk;
            _shippingDate = shippingDate;
            _customerName = customerName;
        }

        public void saveDeskQuote(DeskQuote dq)
        {
            _dq = new List<DeskQuote>();
            _dq.Add(dq);

            // DeskQoute
            string customerName = dq._customerName;
            DateTime dateCreated = dq._shippingDate;

            decimal width = dq._desk.Width;
            decimal depth = dq._desk.Depth;
            string totalSurfaceArea = $"{Math.Round(dq._desk.computeSurfaceArea(width, depth), 2)}";
            
            string sizeCost = Math.Round(dq._desk.computeDeskSizeCost(), 2).ToString("F");

            // Drawer
            string drawerCost = Math.Round(dq._desk.computeDrawerCost(), 2).ToString("F");

            // Surface material
            string material = dq._desk.SurfaceMaterial;
            string materialCost = Math.Round(dq._desk.computeSurfaceMaterialCost(), 2).ToString("F");

            // Shipping details
            string shippingMethod = null;
            int rushOptionDays = dq._desk.RushOrderDay;
            if (rushOptionDays != 14)
            {
                shippingMethod = $"Rush - {rushOptionDays} Days";
            }
            else
            {
                shippingMethod = $"Normal - {rushOptionDays} Days";
            }
            
            string shippingCost = Math.Round(dq._desk.computeShippingCost(), 2).ToString("F");

            // Total cost
            string totalCost = Math.Round(dq._desk.computeDeskPrice(), 2).ToString("F");

            string deskQuote = $"{customerName}, {dateCreated}, {totalSurfaceArea}, " +
                        $"{sizeCost}, {drawerCost}, {material}, {materialCost}, {shippingMethod}, " +
                        $"{shippingCost}, {totalCost}";

            string path = @"qoutes.txt";
            // This text is added only once to the file
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                    sw.WriteLine(deskQuote);
                }
            }

            // This text is always added, making file longer over time
            // if not deleted
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(deskQuote);
            }
        } 

        public void displayDeskQuotes()
        {
            foreach(var dq in _dq)
            {
                Console.WriteLine($"Customer Name: {dq._customerName}, Shipping Date: {dq._shippingDate}, Total Desk Price: {dq._desk.computeDeskPrice()}");
            }
        }
    }
}
