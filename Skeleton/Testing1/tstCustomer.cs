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
           Boolean TestData =  true;
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
            Boolean  found = false;
            //create some test data to assign to the property
            Int32 CustomerID = 3;
            //invoke the method
            found = customer.Find(CustomerID);
            //test to see that the two values are the same
            Assert.IsTrue(found);


        }

       


    }
}
    
