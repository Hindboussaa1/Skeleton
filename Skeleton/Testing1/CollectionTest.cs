using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    class CollectionTest
    {
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
            customer.CustomerID = 1;
            customer.Email = "test@example.com";
            customer.CustomerActive = true;

            // Act
            mCustomerCollection.AddCustomer(customer);

            // Assert
            Assert.AreEqual(1, mCustomerCollection.CustomerList.Count);
            Assert.AreEqual(customer, mCustomerCollection.FindCustomerByID(1));
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
            Int32 sum_count = 2;
            customer.get_customer();
           int count= customer.customerCollection.CustomerList.Count;
            Assert.AreEqual(count, sum_count);
        }
    }
}
