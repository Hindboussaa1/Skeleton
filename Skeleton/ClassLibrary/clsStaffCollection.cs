using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff { get
            {
                return mThisStaff;
            } set
            {
                mThisStaff = value;
            }
        }
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaffTable_SelectAll");
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff aStaff = new clsStaff();

                aStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffAvailable"]);
                aStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                aStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                aStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullName"]);
                aStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                aStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StaffAvailable", mThisStaff.Active);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffStartDate", mThisStaff.DateAdded);

            return DB.Execute("sproc_tblStaffTable_Insert");
        }
    }
}