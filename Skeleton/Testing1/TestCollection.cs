using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    public class TestCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            CustomerCollection AllCustomers = new CustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            CustomerCollection AllCustomers = new CustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Hinda";
            TestItem.Address = "123 London Road";
            TestItem.Email = "hinda@gmail.com";
            TestItem.CustomerActive = true;
            TestItem.Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            CustomerCollection AllCustomers = new CustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.Name = "Hinda";
            TestCustomer.Address = "123 London Road";
            TestCustomer.Email = "hinda@gmail.com";
            TestCustomer.CustomerActive = true;
            TestCustomer.Date = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers. = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(TestCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Hinda";
            TestItem.Address = "123 London Road";
            TestItem.Email = "hinda@gmail.com";
            TestItem.CustomerActive = true;
            TestItem.Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }




    }

