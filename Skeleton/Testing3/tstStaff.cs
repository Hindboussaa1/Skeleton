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
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Int32 TestData = 1;
            aStaff.StaffId = TestData;
            Assert.AreEqual(aStaff.StaffId, TestData);
        }
        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "abc";
            aStaff.StaffRole = TestData;
            Assert.AreEqual(aStaff.StaffRole, TestData);
        }
        [TestMethod]
        public void StaffFullNamePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "ab";
            aStaff.StaffFullName = TestData;
            Assert.AreEqual(aStaff.StaffFullName, TestData);
        }
        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "ab";
            aStaff.StaffEmail = TestData;
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 21;
            Found = aStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.StaffId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.DateAdded!= Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //fullname
        public void TestFullNameFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.StaffFullName != "test name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //staff available
        [TestMethod]
        
        public void TestStaffAvailableFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //role
        [TestMethod]
        
        public void TestStaffRoleFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.StaffRole != "test role")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //email
        [TestMethod]
        
        public void TestStaffEmailFound()
        {
            clsStaff staffId = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = staffId.Find(StaffId);
            if (staffId.StaffEmail != "test email")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
