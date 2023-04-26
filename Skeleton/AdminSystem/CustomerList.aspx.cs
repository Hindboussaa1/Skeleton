using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    private string txtName;
    private int CustomerID;//textbox3
    private string Address;//1
    private string Email;//5

    private DateTime Date;// 4
    private bool check = false;
    clsCustomerCollection cc = new clsCustomerCollection();
    CustomerCollection list;
    protected void Page_Load(object sender, EventArgs e)
    {
        get_data();
    }

    private void get_data()
    {
        if (list != null)
        {
            if (list.CustomerList.Count > 0)
            {
                list.CustomerList.Clear();
            }
        }
          list= cc.GetCustomer();
        DataTable dt = new DataTable();
        dt.Columns.Add("CustomerID", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Email", typeof(string));
        dt.Columns.Add("Date", typeof(int));
        dt.Columns.Add("Address", typeof(string));
        dt.Columns.Add("CustomerActive", typeof(bool));

        // Loop through the customers ArrayList and add each one to the DataTable
        foreach (clsCustomer customer in list.CustomerList)
        {
            DataRow row = dt.NewRow();
            row["CustomerId"] = customer.CustomerID;
            row["Name"] = customer.Name;
            row["Email"] = customer.Email;
            ///row["Date"] = customer.Date.ToString();
            row["Address"] = customer.Address;
            row["CustomerActive"] = customer.CustomerActive;
            dt.Rows.Add(row);
        }
        GridView1.Visible = true;
        // Bind the DataTable to the DataGridView
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            txtName = TextBox2.Text;

            CustomerID = int.Parse(TextBox3.Text);
            Address = TextBox1.Text;
            Email = TextBox5.Text;
            check = chkActive.Checked;
            //Date = DateTime.Parse(TextBox4.Text);

            // create  a new instance of clsCustomer
            clsCustomer customer1 = new clsCustomer();
            //capture the Name
            customer1.Name = txtName;
            customer1.CustomerID = CustomerID;
            customer1.Address = Address;
            customer1.Email = Email;
            customer1.CustomerActive = check;
            customer1.Date = Date;
            clsCustomerCollection cs = new clsCustomerCollection();
            cs.add(customer1);

        }
    }
        private bool ValidateInput()
    {
        bool isValid = true;

        // Validate the txtName field
        if (string.IsNullOrEmpty(TextBox2.Text))
        {
            CustomValidator cv = new CustomValidator("Name is required");
            cv.ValidationGroup = "InputValidation";
            cv.ControlToValidate = "txtName";
            Page.Validators.Add(cv);
            isValid = false;
        }

        // Validate the CustomerID field
        int customerID;
        if (!int.TryParse(TextBox3.Text, out customerID))
        {
            CustomValidator cv = new CustomValidator("Customer ID must be a number");
            cv.ValidationGroup = "InputValidation";
            cv.ControlToValidate = "TextBox3";
            Page.Validators.Add(cv);
            isValid = false;
        }

        // Validate the Address field
        if (string.IsNullOrEmpty(TextBox1.Text))
        {
            CustomValidator cv = new CustomValidator("Address is required");
            cv.ValidationGroup = "InputValidation";
            cv.ControlToValidate = "Address";
            Page.Validators.Add(cv);
            isValid = false;
        }

        // Validate the Email field
        if (!string.IsNullOrEmpty(TextBox5.Text))
        {
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(TextBox5.Text))
            {
                CustomValidator cv = new CustomValidator("Email is not valid");
                cv.ValidationGroup = "InputValidation";
                cv.ControlToValidate = "Email";

                isValid = false;
            }
        }

        return isValid;
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int customerId = int.Parse(GridView1.SelectedDataKey.Value.ToString());
        clsCustomer customer = list.FindCustomerByID(customerId);
        TextBox2.Text = customer.Name;
        TextBox3.Text = customer.CustomerID.ToString();
        TextBox1.Text = customer.Address;
        TextBox5.Text = customer.Email;
        chkActive.Enabled = customer.CustomerActive;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        txtName = TextBox2.Text;

        CustomerID = int.Parse(TextBox3.Text);
        Address = TextBox1.Text;
        Email = TextBox5.Text;
        check = chkActive.Checked;
        //Date = DateTime.Parse(TextBox4.Text);
        clsCustomer customer1 = new clsCustomer();
        //capture the Name
        customer1.Name = txtName;
        customer1.CustomerID = CustomerID;
        customer1.Address = Address;
        customer1.Email = Email;
        customer1.CustomerActive = check;
        customer1.Date = Date;
        cc.update(customer1);
        get_data();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        CustomerID = int.Parse(TextBox3.Text);
        cc.delete(CustomerID);
        get_data();

    }
}