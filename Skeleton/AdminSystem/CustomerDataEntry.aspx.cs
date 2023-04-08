using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
   private string txtName;

    //public int getType { get; private set; }
   
    protected void btnOK_Click(object sender, EventArgs e)
    {
        txtName = TextBox2.Text;
        // create  a new instance of clsCustomer
        clsCustomer customer1 = new clsCustomer();
        //capture the Name
        customer1.Name = txtName;
        //store  customer in the session object
        Session["Customer"] = customer1;
        //navigate to the viewr page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // create  a new instance of clsCustomer
        clsCustomer Customer =new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entred by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = CustomerID.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = CustomerID.Name;
            txtEmail.Text = CustomerID.Email;
            txtDate.Text = CustomerID.Date;
            txtAddress.Text = CustomerID.Address;
            txtCustomerActive.Text = CustomerID.CustomerActive;

        }
    
    }
}