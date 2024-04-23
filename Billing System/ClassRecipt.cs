using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class ClassRecipt
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string total { get { return string.Format("{0}$", price * quantity); } }

    }
}
