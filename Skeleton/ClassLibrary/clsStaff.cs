using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffId { get; set; }
        public string StaffRole { get; set; }
        public string StaffFullName { get; set; }
        public string StaffEmail { get; set; }
    }
}