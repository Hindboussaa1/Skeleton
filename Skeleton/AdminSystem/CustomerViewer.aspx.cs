using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance  of clsCustomer
        clsCustomer customer1 = new clsCustomer();
        //get the data  from the seesion object
        customer1 = (clsCustomer) Session["Customer"];
        // display the name for this entry
       // Label_Customer_Name.Text = "Customer Name: " + customer1.Name;
        Response.Write(customer1.Name);


    }
}