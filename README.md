# Skeleton
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testc
{


    [TestClass]
    public class testCustomerManagement
    {
        private string hindamingmailcom;
        private string roadmayflower;

        public int Numberofcustomerhandled { get; private set; }
        public string Address { get; private set; }
        public int Phone { get; private set; }
        public string Email { get; private set; }
        public int CustomerID { get; private set; }
        public int Name { get; private set; }

        [TestMethod]
        public void Instanceok()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //test to see that it exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void CustomerIDOk ()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            int TestData = 9;
            //assign the data to the property
            customer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CustomerID, TestData);
        }

        [TestMethod]
        public void NameOk ()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            int TestData = 9;
            //assign the data to the property
            customer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Name, TestData);
        }




        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            String TestData = hindamingmailcom;
            //assign the data to the property
            customer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Email, TestData);
        }


        [TestMethod]
        public void PhoneOK()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            Int32 TestData = 1564367;
            //assign the data to the property
            customer.Phone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Phone, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            String TestData = roadmayflower;
            //assign the data to the property
            customer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Address, TestData);
        }

        [TestMethod]
        public void NumberofcustomerhandledOK()
        {
            //create an instance of the class we want to create
            testCustomerManagement customer = new testCustomerManagement();
            //create some test data to assign to the property
            Int32 TestData = 54;
            //assign the data to the property
            customer.Numberofcustomerhandled = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Numberofcustomerhandled, TestData);
        }
    }
    }
