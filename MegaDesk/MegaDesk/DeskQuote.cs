using System;
using System.Collections;
using System.Collections.Generic;
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
