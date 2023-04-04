using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //private const string V = "CustomerID";
        //private const string V1 = "Testname";
        //private string = "roadmayflower";

        public string Address { get; private set; }
        public string Email { get; private set; }
        //public int CustomerID { get; private set; }
        public int Name { get; private set; }
        //public string Roadmayflower { get = roadmayflower; set => roadmayflower = value; }

        //public string Hindamingmailcom { get; }
        public bool Found { get; private set; }

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

        /* [TestMethod]
         public void NameOk()
         {
             //create an instance of the class we want to create
             clsCustomer customer = new clsCustomer();
             //create some test data to assign to the property
             int TestData = 9;
             //assign the data to the property
             customer.Name = TestData;
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
            Int32 CustomerID = 3;
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
            int CustomerID = 9;
            //invoke the method
            Found = customer.Find(CustomerID);
            //check the  customerID
            if (customer.CustomerID != 9)
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
            String Email = "Hindamingmailcom";
            //invoke the method
            Found = customer.Find(Email);
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
            String Address = "43tavistock";
            //invoke the method
            Found = customer.Find(Address);
            //check the   Address
            if (customer.Address != "43tavistock")
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
            DateTime TestData = DateTime.Now.Date;
            //invoke the method
            Found = customer.Find(Date);
            //check the   Address
            if (customer.Date != DateTime.Now.Date) ;
            {
                OK = false;
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
            Boolean CustomerActive = true;
            //invoke the method
            Found = customer.Find(CustomerActive);
            //check the  CustomerActive
            if (customer.CustomerActive != true) ;
            {
                OK = false;
            }
            //test to see that the  result is correct
            Assert.IsTrue(OK);
        }

    }
}

