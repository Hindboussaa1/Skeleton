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


       

    /*public bool Find(string Email)
    {
        mEmail = "Hindamingmailcom";
        return true;
    }

    public bool Find(object customerActive)
    {
        throw new NotImplementedException();
    }

    public bool Find(object date)
    {
        throw new NotImplementedException();
    }
    */
}



