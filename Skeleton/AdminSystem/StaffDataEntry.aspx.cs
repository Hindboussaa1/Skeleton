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
        string StaffId = txtStaffId.Text;
        string FullName = txtStaffFullName.Text;
        string Role = txtStaffRole.Text;
        string DateAdded = txtStaffStartDate.Text;
        bool Active = chkAvailable.Checked;
        string Email = txtStaffEmail.Text;
        string Error = "";
        Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
        if (Error == "")
        {
            aStaff.StaffId = Convert.ToInt32(StaffId);
            aStaff.StaffEmail = Email;
            aStaff.StaffRole = Role;
            aStaff.DateAdded = Convert.ToDateTime(DateAdded);
            aStaff.StaffFullName = FullName;
            aStaff.Active = chkAvailable.Checked;
            Session["aStaff"] = aStaff;
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

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