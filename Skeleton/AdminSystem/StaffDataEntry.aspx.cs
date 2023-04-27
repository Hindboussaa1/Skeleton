using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayAdress();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        //id
        string StaffID = txtStaffId.Text;
        string FullName = txtStaffFullName.Text;
        string Role = txtStaffRole.Text;
        string DateAdded = txtStaffStartDate.Text;
        bool Active = chkAvailable.Checked;
        string Email = txtStaffEmail.Text;
        string Error = "";
        Error = aStaff.Valid(Role, Email, DateAdded, Active, FullName);
        if (Error == "")
        {
            aStaff.StaffId = StaffId;
            aStaff.StaffEmail = Email;
            aStaff.StaffRole = Role;
            aStaff.DateAdded = Convert.ToDateTime(DateAdded);
            aStaff.StaffFullName = FullName;
            aStaff.Active = chkAvailable.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                StaffList.ThisStaff = aStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = aStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
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
    void DisplayAdress()
    {
        clsStaffCollection Staffbook = new clsStaffCollection();
        Staffbook.ThisStaff.Find(StaffId);
        txtStaffEmail.Text = Staffbook.ThisStaff.StaffEmail;
        txtStaffFullName.Text = Staffbook.ThisStaff.StaffFullName;
        txtStaffRole.Text = Staffbook.ThisStaff.StaffRole;
        txtStaffStartDate.Text = Staffbook.ThisStaff.DateAdded.ToString();
        chkAvailable.Checked = Staffbook.ThisStaff.Active;

        
    }
}