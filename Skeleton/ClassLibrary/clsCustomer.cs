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
            /* mCustomerID = CustomerID;
            mEmail = "Hindamingmailcom";
            mCustomerActive = true;
           // mDate = 15;
            mAddress = "tavistock";
            return true;*/

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored prosedure
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //ifone record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copythe data from the database to the private data members

                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                //  mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                //return that  everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;

            }
        }

    }
}
