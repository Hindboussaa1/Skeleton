using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }

    }

    private void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "CarId";
        lstStockList.DataValueField = "CarBrand";
        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CarId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CarId;
        if (lstStockList.SelectedIndex != 1)
        {
            CarId = Convert.ToInt32(lstStockList.SelectedValue);

            Session["CarId"] = CarId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = " Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CarId;
        if(lstStockList.SelectedIndex != -1)
        {
            CarId = Convert.ToInt32(lstStockList.SelectedValue);

            Session.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByCarBrand(txtCarBrand.Text);
        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "CarId";
        lstStockList.DataTextField = "CarBrand";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByCarBrand("");
        txtCarBrand.Text = "";
        lstStockList.DataValueField = "CarId";
        lstStockList.DataTextField = "CarBrand";
        lstStockList.DataBind();
    }
}