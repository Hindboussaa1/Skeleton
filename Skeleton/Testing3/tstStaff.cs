using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
       
        string FullName = "hamoud 7abibi";
        string Role = "waking up his brother from sleep";
        string Email = "hamoudhabibi@gmail.com";
        bool Active = true;
        string DateAdded = DateTime.Now.Date.ToString();
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "a";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aaaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');

            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            
            string DateAdded = TestDate.ToString();
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+1);
            string DateAdded = TestDate.ToString();
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string DateAdded = "this is not a date!";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void RoleMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "a";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "aa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "aaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "aaaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "aaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "aaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Role = "";
            FullName = FullName.PadRight(500, 'a');

            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        //-------------------------------------------------------
        //---------------------------------------
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "a";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "aa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "aaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "aaaaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "aaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "aaaa";
            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string Email = "";
            FullName = FullName.PadRight(500, 'a');

            Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
            Assert.AreNotEqual(Error, "");
        }
    }
}
