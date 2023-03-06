using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object txtName;

    public int getType { get; private set; }
    protected void Pgae_load(object sender, EventArgs e)
    {
    }
        protected void btnOK_Click(object sender, EventArgs e)
    {
        // create  a new instance of clsCustomer
        clsCustomer customer = new clsCustomer();
        //capture the Name
        customer.Name= getType;
        //store  customer in the session object
        Session["customer"]=customer;
        //navigate to the viewr page
        Response.Redirect("_1Viewer.aspx");
    }
}