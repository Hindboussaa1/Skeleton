using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private DateTime mDateAdded;
        private string mStaffRole;
        private string mStaffFullName;
        private string mStaffEmail;
        private Boolean mActive;
        public bool Active {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded { get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public int StaffId { get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        public string StaffRole {
            get
            {
                return mStaffRole;
            }
            set
            {
                mStaffRole = value;
            }
        }
        public string StaffFullName {
            get
            {
                return mStaffFullName;
            }
            set
            {
                mStaffFullName = value;
            }
        }
        public string StaffEmail {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }
        
        public bool Find(int StaffID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer ID to search for
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaffTable_FilterByStaffId");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStartDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffAvailable"]);
                mStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["StaffFullName"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }
    }
}