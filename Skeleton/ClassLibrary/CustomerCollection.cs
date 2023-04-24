using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    using System.Collections;
    using System.Collections.Generic;

    public class CustomerCollection
    {
        // private member variable to store the list of customers
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();

        // public property to return the list of customers
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
        }

        // public method to add a new customer to the list
        public void AddCustomer(clsCustomer customer)
        {
            mCustomerList.Add(customer);
        }

        // public method to remove a customer from the list
        public void RemoveCustomer(clsCustomer customer)
        {
            mCustomerList.Remove(customer);
        }

        // public method to find a customer by ID
        public clsCustomer FindCustomerByID(int customerID)
        {
            foreach (clsCustomer customer in mCustomerList)
            {
                if (customer.CustomerID == customerID)
                {
                    return customer;
                }
            }
            // if customer not found, return null
            return null;
        }

        // public method to find customers by email address
        public List<clsCustomer> FindCustomersByEmail(string email)
        {
            List<clsCustomer> customers = new List<clsCustomer>();
            foreach (clsCustomer customer in mCustomerList)
            {
                if (customer.Email == email)
                {
                    customers.Add(customer);
                }
            }
            return customers;
        }

        // public method to find active customers
        public List<clsCustomer> FindActiveCustomers()
        {
            List<clsCustomer> customers = new List<clsCustomer>();
            foreach (clsCustomer customer in mCustomerList)
            {
                if (customer.CustomerActive)
                {
                    customers.Add(customer);
                }
            }
            return customers;
        }

        // public method to find inactive customers
        public List<clsCustomer> FindInactiveCustomers()
        {
            List<clsCustomer> customers = new List<clsCustomer>();
            foreach (clsCustomer customer in mCustomerList)
            {
                if (!customer.CustomerActive)
                {
                    customers.Add(customer);
                }
            }
            return customers;
        }
    }
}
