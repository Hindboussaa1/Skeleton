using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance  of clsCustomer
        clsCustomer customer = new clsCustomer();
        //get the data  from the seesion object
        customer = (clsCustomer)Session["customer"];
        // display the name for this entry
        Response.Write(customer.Name);

    }
}