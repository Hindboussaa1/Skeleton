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

        public bool Find(int StaffId)
        {
            mStaffId = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mStaffEmail = "test email";
            mStaffRole = "test role";
            mStaffFullName = "test name";
            mActive = true;


            return true;
        }
    }
}