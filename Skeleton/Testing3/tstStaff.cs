using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanseOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        [TestMethod]
        public void StaffAvailablePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.Active = TestData;
            Assert.AreEqual(aStaff.Active, TestData);
        }
        [TestMethod]
        public void StaffDatePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.DateAdded = TestData;
            Assert.AreEqual(aStaff.DateAdded, TestData);
        }
        public void StaffIdPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Int32 TestData = 1;
            aStaff.StaffId = TestData;
            Assert.AreEqual(aStaff.StaffId, TestData);
        }
        public void StaffRolePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "abc";
            aStaff.StaffRole = TestData;
            Assert.AreEqual(aStaff.StaffRole, TestData);
        }
        public void StaffFullNamePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "ab";
            aStaff.StaffFullName = TestData;
            Assert.AreEqual(aStaff.StaffFullName, TestData);
        }
        public void StaffEmailPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "ab";
            aStaff.StaffEmail = TestData;
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 21;
            Found = aStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
    }
}
