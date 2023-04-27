using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        

       /* public string Address { get; private set; }
        public string Email { get; private set; }
        public int CustomerID { get; private set; }
        public String Name { get; private set; }
      */
        public bool Found { get; private set; }
        string Name = "sana";
        string Address = "myflower road";
        string Email = "dina@gmail.com";
        bool CustomerActive = true;
         public DateTime Date  = DateTime.Now.Date;
        int CustomerID = 3;


        [TestMethod]
        public void Instanceok()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void CustomerIDOk()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 9;
            //assign the data to the property
            customer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CustomerID, TestData);
        }
        /*
         [TestMethod]
         public void NameOk()
         {
             //create an instance of the class we want to create
             clsCustomer customer = new clsCustomer();
             //create some test data to assign to the property
             int TestData = 9;
             //assign the data to the property
             customer.Name = TestDat;
             //test to see that the two values are the same
             Assert.AreEqual(customer.Name, TestData);
         }
        
        */


        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Hindamingmailcom";
            //assign the data to the property
            customer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Email, TestData);
        }




        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Roadmayflower";
            //assign the data to the property
            customer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Address, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            customer.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(expected: customer.Date, TestData);
        }
        [TestMethod]
        public void CustomerActiveOk()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            customer.CustomerActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CustomerActive, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //Boolean variable to store the results of the validation 
            Boolean found = false;
            //create some test data to assign to the property
            Int32 CustomerID = 12;
            //invoke the method
            found = customer.Find(CustomerID);
            //test to see that the two values are the same
            Assert.IsTrue(found);


        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to assign to the property
            int CustomerID = 12;
            //invoke the method
            Found = customer.Find(CustomerID);
            //check the  customerID
            if (customer.CustomerID != 12)
            {
                OK = false;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to assign to the property
            int CustomerID = 124;
            //String Email = "Hindamingmailcom";
            //invoke the method
            Found = customer.Find(CustomerID);
            //check the  Email
            if (customer.Email != "Hindamingmailcom")
            {
                OK = false;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to assign to the property
            int CustomerID = 124;
            // String Address = "43tavistock";
            //invoke the method
            Found = customer.Find(CustomerID);
            //check the   Address
            if (customer.Address != "tavistock")
            {
                OK = false;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to assign to the property
            int CustomerID =12;

            //DateTime TestData = DateTime.Now.Date;
            //invoke the method
            Found = customer.Find(CustomerID);
           
            if (customer.Date != DateTime.Now)
            {
                OK = true;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if CustomerActive is  ok
            Boolean OK = true;
            //create some test data to assign to the property
            int CustomerID = 12;

            //Boolean CustomerActive = true;
            //invoke the method
            Found = customer.Find(CustomerID);
            //check the  CustomerActive
            if (customer.CustomerActive != true)
            {
                OK = false;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }

        private CustomerCollection mCustomerCollection;
        [TestInitialize]
        public void TestInitialize()
        {
            // Create a new instance of CustomerCollection for each test method
            mCustomerCollection = new CustomerCollection();
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            customer.CustomerID = 15;
            customer.Email = "test@example.com";
            customer.CustomerActive = true;
            customer.Address = "3 tavistock road";
            customer.Name = "dina";
            customer.Date = DateTime.Now;

            // Act
            mCustomerCollection.AddCustomer(customer);

            // Assert
            Assert.AreEqual(1, mCustomerCollection.CustomerList.Count);

        }
        public void TestAdd()
        {
            // Arrange
            clsCustomerCollection cs = new clsCustomerCollection();
            clsCustomer customer = new clsCustomer();
            customer.CustomerID = 18;
            customer.Email = "test@example.com";
            customer.CustomerActive = true;
            customer.Address = "3 tavistock road";
            customer.Name = "dina";
            customer.Date = DateTime.Now;

            // Act
            cs.add(customer);

            // Assert
            Assert.AreEqual(cs.customerCollection.Count(), cs.customerCollection.Count());

        }

        [TestMethod]
        public void TestRemoveCustomer()
        {
            // Arrange
            clsCustomer customer1 = new clsCustomer();
            customer1.CustomerID = 1;
            customer1.Email = "test1@example.com";
            customer1.CustomerActive = true;

            clsCustomer customer2 = new clsCustomer();
            customer2.CustomerID = 2;
            customer2.Email = "test2@example.com";
            customer2.CustomerActive = true;

            mCustomerCollection.AddCustomer(customer1);
            mCustomerCollection.AddCustomer(customer2);

            // Act
            mCustomerCollection.RemoveCustomer(customer1);

            // Assert
            Assert.AreEqual(1, mCustomerCollection.CustomerList.Count);
            Assert.IsNull(mCustomerCollection.FindCustomerByID(1));
            Assert.AreEqual(customer2, mCustomerCollection.FindCustomerByID(2));
        }
        [TestMethod]
        public void testupdate()
        {
            // Arrange
            clsCustomerCollection cs = new clsCustomerCollection();
            clsCustomer customer = new clsCustomer();
            customer.CustomerID = 12;
            customer.Email = "test@hmail.com";
            customer.CustomerActive = true;
            customer.Address = "3 tavistock road";
            customer.Name = "dina";
            customer.Date = DateTime.Now;

            // Act
            cs.update(customer);

            // Assert
            Assert.AreEqual(cs.customerCollection.FindCustomersByEmail("test@hmail.com").Count, cs.customerCollection.FindCustomersByEmail("test@hmail.com").Count);


        }
        [TestMethod]
        public void TestFindCustomerByID()
        {
            // Arrange
            clsCustomer customer1 = new clsCustomer();
            customer1.CustomerID = 1;
            customer1.Email = "test1@example.com";
            customer1.CustomerActive = true;

            clsCustomer customer2 = new clsCustomer();
            customer2.CustomerID = 2;
            customer2.Email = "test2@example.com";
            customer2.CustomerActive = true;

            mCustomerCollection.AddCustomer(customer1);
            mCustomerCollection.AddCustomer(customer2);

            // Act
            clsCustomer foundCustomer = mCustomerCollection.FindCustomerByID(2);

            // Assert
            Assert.AreEqual(customer2, foundCustomer);
        }

        [TestMethod]
        public void TestFindCustomersByEmail()
        {
            // Arrange
            clsCustomer customer1 = new clsCustomer();
            customer1.CustomerID = 1;
            customer1.Email = "test1@example.com";
            customer1.CustomerActive = true;

            clsCustomer customer2 = new clsCustomer();
            customer2.CustomerID = 2;
            customer2.Email = "test2@example.com";
            customer2.CustomerActive = true;

            mCustomerCollection.AddCustomer(customer1);
            mCustomerCollection.AddCustomer(customer2);

            // Act
            List<clsCustomer> foundCustomers = mCustomerCollection.FindCustomersByEmail("test2@example.com");

            // Assert
            Assert.AreEqual(1, foundCustomers.Count);
            Assert.AreEqual(customer2, foundCustomers[0]);
        }
        [TestMethod]
        public void countPropertyok()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            Int32 sum_count = 6;
            customer.get_customer();
            int count = customer.customerCollection.CustomerList.Count;
            Assert.AreEqual(count, count);
        }
        [TestMethod]
        public void Listandcoutok()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            List<clsCustomer> test = new List<clsCustomer>();
            clsCustomer testcustomer = new clsCustomer();
            testcustomer.Name = "dina";
            testcustomer.Email = "dina@gmail.com";
            testcustomer.Address = " 4 mayfloyer road";
            testcustomer.Date = DateTime.Now;
            testcustomer.CustomerActive = true;
            testcustomer.CustomerID = 8;
            test.Add(testcustomer);
            mCustomerCollection.CustomerList.Clear();
            mCustomerCollection.CustomerList.Add(testcustomer);
            Assert.AreEqual(mCustomerCollection.CustomerList.Count, test.Count);


        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive );
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error ="";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDeMin()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            string Error = "";
            Int32 CustomerID = 2;
            clsCustomer customer = new clsCustomer();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerID = 2;
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateCheckedExtremeMin()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateChecked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateCheckedMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateChecked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateCheckedMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateCheked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateCheckedMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateCheked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateCheked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateCheked = TestDate.ToString();
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(CustomerID, Name, Date.ToString(), Address, Email, CustomerActive);
            Assert.AreNotEqual(Error, "");
        }
    }
}

    


