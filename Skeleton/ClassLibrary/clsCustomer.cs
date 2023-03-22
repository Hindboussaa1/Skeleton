using System;
using System.Diagnostics;

namespace ClassLibrary
{

    public class clsCustomer
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public int Numberofcustomerhandled { get; set; }
        public DateTime Date { get; set; }
        public bool CustomerActive { get; set; }

        public bool Find(int customerID)
        {
            return true;
        }
    }
}

