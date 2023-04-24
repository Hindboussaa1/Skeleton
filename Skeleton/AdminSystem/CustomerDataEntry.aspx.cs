using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private string txtName;
    private int CustomerID;//textbox3
    private string Address;//1
    private string Email;//5

    private DateTime Date;// 4
    private bool check = false;//chkActive
    //public int getType { get; private set; }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        if (ValidateInput())
        {
            txtName = TextBox2.Text;

            CustomerID = int.Parse(TextBox3.Text);
            Address = TextBox1.Text;
            Email = TextBox5.Text;
            check = chkActive.Checked;
            Date = DateTime.Parse(TextBox4.Text);

            // create  a new instance of clsCustomer
            clsCustomer customer1 = new clsCustomer();
            //capture the Name
            customer1.Name = txtName;
            customer1.CustomerID = CustomerID;
            customer1.Address = Address;
            customer1.Email = Email;
            customer1.CustomerActive = check;
            customer1.Date = Date;
            //store  customer in the session object
            Session["Customer"] = customer1;
            //navigate to the viewr page
            Response.Redirect("CustomerViewer.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

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
}