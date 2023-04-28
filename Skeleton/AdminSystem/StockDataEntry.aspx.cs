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
       
        string CarBrand = txtCarBrand.Text;
        string CarModel = txtCarModel.Text;
        string CarColor = txtCarColor.Text;
        bool Active = chkAvailable.Checked;
        string DateAdded = txtCarYear.Text;
        string Error = "";
        Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
        if (Error == "")
        {
            StockManage.CarId = Convert.ToInt32(txtCarID.Text);
            StockManage.CarBrand = txtCarBrand.Text;
            StockManage.CarColor = txtCarColor.Text;
            StockManage.CarModel = txtCarModel.Text;
            StockManage.DateAdded = Convert.ToDateTime(txtCarYear.Text);
            StockManage.Active = chkAvailable.Checked;

            Session["StockManage"] = StockManage;
            Response.Redirect("StockViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }


        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSstock StockManage = new clsSstock();
        Int32 CarId;
        Boolean Found = false;

        CarId = Convert.ToInt32(txtCarID.Text);

        Found = StockManage.Find(CarId);

        if (Found = true)
        {
            txtCarBrand.Text = StockManage.CarBrand;
            txtCarModel.Text = StockManage.CarModel;
            txtCarColor.Text = StockManage.CarColor;
            txtCarYear.Text = StockManage.DateAdded.ToString();
            chkAvailable.Checked = StockManage.Active;
        }
    }
}