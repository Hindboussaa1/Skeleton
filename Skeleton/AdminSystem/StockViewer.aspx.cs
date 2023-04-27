using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSstock StockManage = new clsSstock();

        StockManage = (clsSstock)Session["StockManage"];

        Response.Write(StockManage.CarId + "\r \n");
        
        Response.Write(StockManage.Active + "\r \n");
        Response.Write(StockManage.CarBrand + "\r \n");
        Response.Write(StockManage.CarColor + "\r \n");
        Response.Write(StockManage.CarModel + "\r \n");
        Response.Write(StockManage.DateAdded+ "\r \n");

    }
}