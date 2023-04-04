using System;
using System.Diagnostics;

namespace ClassLibrary
{

    public class clsCustomer
    {
        private int mCustomerID;
        private string mEmail;
        private string mAddress;
        private DateTime mDate;
        private Boolean mCustomerActive;


        public string Name { get; set; }
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        public string Email
        {
            get
            {
                return mEmail;
            }

            set
            {
                mEmail = value;
            }
        }
        //public int Phone { get; set; }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }

        public bool CustomerActive
        {
            get
            {
                return mCustomerActive;

            }


            set
            {
                mCustomerActive = value;
            }
        }

        public bool Find(int CustomerID)
        {
            int mCustomerID = 9;
            string mEmail = "Hindamingmailcom";
            return true;
        }

    }

   
}



