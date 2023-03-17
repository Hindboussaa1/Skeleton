using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        aStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        Session["aStaff"] = aStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}