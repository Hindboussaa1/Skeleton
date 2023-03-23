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
}