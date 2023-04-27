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
        public void add(clsCustomer customer)
        {
            clsDataConnection DB = new clsDataConnection();
            /*
             *  clsCustomer customer = new clsCustomer();
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                customerCollection.AddCustomer(customer);
             */
            DB.AddParameter("@IdCustomerID", customer.CustomerID);
            DB.AddParameter("@Name", customer.Name);
            DB.AddParameter("@Email", customer.Email);
            DB.AddParameter("@Date", 1);
            DB.AddParameter("@CustomerActive", customer.CustomerActive);
            DB.AddParameter("@Address", customer.Address);
            DB.Execute("InsertCustomer");
            AddCustomer(customer);
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
        public void update_customer(clsCustomer customer)
        {
            if (FindCustomerByID(customer.CustomerID) != null)
            {
                RemoveCustomer(customer);
                AddCustomer(customer);
            }
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
        public int Count()
        {
            return mCustomerList.Count;
        }
       
       
    }
   public class clsCustomerCollection
    {
       public CustomerCollection customerCollection = new CustomerCollection();

        public void get_customer()
        {
            Int32 index = 0;
            Int32 record = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Customer_selectAll");
            record = DB.Count;
            while (index < record)
            {
                clsCustomer customer = new clsCustomer();
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                customerCollection.AddCustomer(customer);
                index++;
            }

        }
        public void add(clsCustomer customer)
        {
            clsDataConnection DB = new clsDataConnection();
            /*
             *  clsCustomer customer = new clsCustomer();
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                customerCollection.AddCustomer(customer);
             */
            DB.AddParameter("@IdCustomerID", customer.CustomerID);
            DB.AddParameter("@Email", customer.Email);
            DB.AddParameter("@Date", 1);
            DB.AddParameter("@CustomerActive", customer.CustomerActive);
            DB.AddParameter("@Address", customer.Address);
            DB.Execute("InsertCustomer");
            customerCollection.AddCustomer(customer);
        }
        public void update(clsCustomer customer)
        {
            clsDataConnection DB = new clsDataConnection();
            /*
             *  clsCustomer customer = new clsCustomer();
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                customerCollection.AddCustomer(customer);
             */
            DB.AddParameter("@IdCustomerID", customer.CustomerID);
            DB.AddParameter("@Email", customer.Email);
            DB.AddParameter("@Date", 1);
            DB.AddParameter("@CustomerActive", customer.CustomerActive);
            DB.AddParameter("@Address", customer.Address);
            DB.Execute("UpdateCustomer");
            customerCollection.AddCustomer(customer);
        }
        public clsCustomer find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // if one record is found (there should be either one or zero!)
            clsCustomer customer = new clsCustomer();
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["IdCustomerID "]);
                customer.Name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                // return that everything worked ok
                return customer;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return null;
            }
        }
        public void delete(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // execute the stored procedure
            DB.Execute("DeleteCustomer");
            
        }
        public CustomerCollection GetCustomer()
        {
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer ID to search for
            CustomerCollection list = new CustomerCollection();
            // execute the stored procedure
            DB.Execute("GetAllCustomers");
            // if one record is found (there should be either one or zero!)

            for(int i = 0;i<DB.Count;i++) { 
                clsCustomer customer = new clsCustomer();
            // copy the data from the database to the private data members
            customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[i]["IdCustomerID "]);
                customer.Name = Convert.ToString(DB.DataTable.Rows[i]["Name"]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                customer.CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[i]["CustomerActive"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[i]["Address"]);
                // return that everything worked ok
                list.AddCustomer(customer);
               
            }
            return list;
        }
    }

}


