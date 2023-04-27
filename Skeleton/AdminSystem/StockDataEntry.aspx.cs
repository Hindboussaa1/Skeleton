using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSstock StockManage = new clsSstock();
        StockManage.CarId = Convert.ToInt32(txtCarID.Text);
        StockManage.CarBrand = txtCarBrand.Text;
        StockManage.CarColor = txtCarColor.Text;
        StockManage.CarModel = txtCarModel.Text;
        StockManage.DateAdded = Convert.ToDateTime(txtCarYear.Text);
        StockManage.Active = chkAvailable.Checked;

        Session["StockManage"] = StockManage;
        Response.Redirect("StockViewer.aspx");
    }
}