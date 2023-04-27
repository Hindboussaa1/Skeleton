using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "mail";
            TestItem.StaffFullName = "name";
            TestItem.StaffRole = "role";
            TestItem.StaffId = 1;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.Active = true;
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.StaffEmail = "mail";
            TestStaff.StaffFullName = "name";
            TestStaff.StaffRole = "role";
            TestStaff.StaffId = 1;
            
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.StaffList, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "mail";
            TestItem.StaffFullName = "name";
            TestItem.StaffRole = "role";
            TestItem.StaffId = 1;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "mail";
            TestItem.StaffFullName = "name";
            TestItem.StaffRole = "role";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "mail";
            TestItem.StaffFullName = "name";
            TestItem.StaffRole = "role";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.Active = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "another mail";
            TestItem.StaffFullName = "another name lol";
            TestItem.StaffRole = "and another role";
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffEmail = "mail";
            TestItem.StaffFullName = "name";
            TestItem.StaffRole = "role";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        
    }

}
