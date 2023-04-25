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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = staff.Find(StaffId);
        if (Found == true)
        {
            txtStaffFullName.Text = staff.StaffFullName;
            txtStaffRole.Text = staff.StaffRole;
            txtStaffEmail.Text = staff.StaffEmail;
            txtStaffStartDate.Text = staff.DateAdded.ToString();
            chkAvailable.Checked = staff.Active;
        }
    }
}