using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CarId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CarId = Convert.ToInt32(Session["CarId"]);
        if (IsPostBack == false)

        {
            if (CarId != -1)
            {
                DisplayStock();
                }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSstock StockManage = new clsSstock();
        Int32 CarId = txtCarID.Text;
        string CarBrand = txtCarBrand.Text;
        string CarModel = txtCarModel.Text;
        string CarColor = txtCarColor.Text;
        bool Active = chkAvailable.Checked;
        string DateAdded = txtCarYear.Text;
        string Error = "";
        Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
        if (Error == "")
        {
            StockManage.CarId = CarId;
            StockManage.CarBrand = CarBrand;
            StockManage.CarColor = CarColor;
            StockManage.CarModel = CarModel;
            StockManage.DateAdded = Convert.ToDateTime(DateAdded);
            StockManage.Active = chkAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();

            if(CarId == -1)
            {
                StockList.ThisStock = StockManage;
                StockList.Add();

            }
            else
            {
                StockList.ThisStock.Find(CarId);
                StockList.ThisStock = StockManage;
                StockList.Update();
            }
           
            Response.Redirect("StockList.aspx");
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
    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(CarId);
        txtCarBrand.Text = Stock.ThisStock.CarId.ToString();
        txtCarModel.Text = Stock.ThisStock.CarModel;
        txtCarColor.Text = Stock.ThisStock.CarColor;
        txtCarYear.Text = Stock.ThisStock.DateAdded.ToString;
        chkAvailable.Checked = Stock.ThisStock.Active;
    }
}