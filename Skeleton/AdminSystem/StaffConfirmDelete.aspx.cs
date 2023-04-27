using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffID"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffId);
        StaffBook.Delete();
        Response.Redirect("StaffList.aspx");
    }
}