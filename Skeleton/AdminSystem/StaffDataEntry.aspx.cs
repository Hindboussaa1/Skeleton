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
        //id
        aStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        aStaff.StaffFullName = txtStaffFullName.Text;
        aStaff.StaffRole = txtStaffRole.Text;
        aStaff.DateAdded = Convert.ToDateTime(txtStaffStartDate);
        aStaff.Active = chkAvailable.Checked;
        aStaff.StaffEmail = txtStaffEmail.Text;
        Session["aStaff"] = aStaff;
        Response.Redirect("StaffViewer.aspx");

    }
}