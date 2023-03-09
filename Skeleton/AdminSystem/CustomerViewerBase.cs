using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    //public object Customer { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance  of clsCustomer
        clsCustomer Customer1 = new clsCustomer();
        //get the data  from the seesion object
        clsCustomer Customer1 = (clsCustomer)Session["Customer1"];
        // display the name for this entry
        Response.Write(Customer1.Name);

    }
}