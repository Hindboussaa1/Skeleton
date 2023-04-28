using System;
using System.Collections.Generic;

namespace ClassLibrary
{
  
    public class clsStockCollection
    {
        clsSstock mThisStock = new clsSstock();

        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;
           
            
            RecordCount = DB.Count;
            mStockList = new List<clsSstock>();
            while (Index < RecordCount)
            {
                clsSstock AnStock = new clsSstock();
                AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStock.CarId = Convert.ToInt32(DB.DataTable.Rows[Index]["CarId"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.CarBrand = Convert.ToString(DB.DataTable.Rows[Index]["CarBrand"]);
                AnStock.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnStock.CarColor = Convert.ToString(DB.DataTable.Rows[Index]["CarColor"]);
                mStockList.Add(AnStock);
                Index++;
            }

        }
        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);





            // clssstock testitem = new clssstock();
            // testitem.active = true;
            //  testitem.carid = 1;
            //  testitem.carbrand = "mercedes";
            //  testitem.carmodel = "e320";
            // testitem.carcolor = "black";
            //testitem.dateadded = datetime.now.date;
            //mstocklist.add(testitem);

            //testitem = new clssstock();
            //testitem.active = true;
            //testitem.carid = 2;
            //testitem.carbrand = "bmw";
            //  testitem.carmodel = "m5";
            // testitem.carcolor = "white";
            //  testitem.dateadded = datetime.now.date;
            // mstocklist.add(testitem);
        }

        List<clsSstock> mStockList = new List<clsSstock>();
        
        public List<clsSstock> StockList { 
            get {
                return mStockList;
            }
            set 
            {
                mStockList = value;
            }
        }
        public int Count {
            get {
                return mStockList.Count;
            }
            set
            {
               


            }
        }
        public clsSstock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarId", mThisStock.CarId);
            DB.AddParameter("@CarBrand", mThisStock.CarBrand);
            DB.AddParameter("@CarMode", mThisStock.CarModel);
            DB.AddParameter("@CarColor", mThisStock.CarColor);
            DB.AddParameter("@Active", mThisStock.Active);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarId", mThisStock.CarId);
            DB.AddParameter("@CarBrand", mThisStock.CarBrand);
            DB.AddParameter("@CarMode", mThisStock.CarModel);
            DB.AddParameter("@CarColor", mThisStock.CarColor);
            DB.AddParameter("@Active", mThisStock.Active);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarId", mThisStock.CarId);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByCarBrand(string CarBrand)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarBrand", CarBrand);
            DB.Execute("sproc_tblStock_FilterByCarBrand");
            PopulateArray(DB);
        }
         
       
           
        
    }
}