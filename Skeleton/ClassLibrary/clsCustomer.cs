using System;
using System.Data;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerID;
        private string mEmail;
        private string mAddress;
        private string mName;

        private DateTime mDate;
      

        private bool mCustomerActive;

        public string Name { get; set; }
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
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

       

        public bool CustomerActive
        {
            get { return mCustomerActive; }
            set { mCustomerActive = value; }
        }

        public bool Find(int CustomerID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                // return that everything worked ok
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }
    public  String Valid(int CustomerID, String Name ,String  DateChecked, string Address, string Email, bool CustomerActive)
    {
        String Error = "";
        DateTime DateTemp;
        if (Address.Length == 0)
        {
            Error = Error + "The Address may not be blank : ";

        }
        if (Address.Length > 100)
        {
            Error = Error + "Address must be no longer than 100 characters: ";

        }

        if (Name.Length == 0)
        {
            Error = Error + "NAme may not be blank : ";

        }
        if (Name.Length > 100)
        {
            Error = Error + "Name must be no longer than 100 characters: ";

        }

        if (Email.Length == 0)
        {
            Error = Error + "The email may not be blank : ";

        }
        if (Email.Length > 100)
        {
            Error = Error + "The email must be no longer than 100 characters: ";

        }
        try
        {
            DateTemp = Convert.ToDateTime(DateChecked);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past: ";

            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future: ";
            }

        }
        catch
        {
            Error = Error + "The date was not a valid date: ";
        }


        return Error;
    }
      }
    }




