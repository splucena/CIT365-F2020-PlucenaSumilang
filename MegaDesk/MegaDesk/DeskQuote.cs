using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        private Desk _desk;
        private DateTime _shippingDate;
        private String _customerName;

        public DeskQuote(Desk desk, DateTime shippingDate, String customerName)
        {
            _desk = desk;
            _shippingDate = shippingDate;
            _customerName = customerName;
        }
    }
}
