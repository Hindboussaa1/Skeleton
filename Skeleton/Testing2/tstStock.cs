using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        string CarBrand = "Mercedes";
        string CarModel = "E320";
        string CarColor = "Black";
        bool Active = true;
        string DateAdded = DateTime.Now.Date.ToString();
        



        
        [TestMethod]
        public void InstanceOK()
        {
            clsSstock StokManage = new clsSstock();
            Assert.IsNotNull(StokManage);
        }
        [TestMethod]
        public void ActiveStock()
        {
            clsSstock StockManage = new clsSstock();
            Boolean TestData = true;
            StockManage.Active = TestData;
            Assert.AreEqual(StockManage.Active, TestData);

        }
        [TestMethod]
        public void CarYearkOK()
        {
            clsSstock StockManage = new clsSstock();
            DateTime TestData = DateTime.Now.Date;
            StockManage.DateAdded = TestData;
            Assert.AreEqual(StockManage.DateAdded, TestData);
        }
        [TestMethod]
        public void CarIdStockOK()
        {
            clsSstock StockManage = new clsSstock();
            Int32 TestData = 1;
            StockManage.CarId = TestData;
            Assert.AreEqual(StockManage.CarId, TestData);
        }
        [TestMethod]
        public void CarBrandOK()
        {
            clsSstock StockManage = new clsSstock();
            string TestData = "Mercedes";
            StockManage.CarBrand = TestData;
            Assert.AreEqual(StockManage.CarBrand, TestData);
        }
        [TestMethod]
        public void CarModelOK()
        {
            clsSstock StockManage = new clsSstock();
            string TestData = "E320";
            StockManage.CarModel = TestData;

            Assert.AreEqual(StockManage.CarModel, TestData);
        }
        [TestMethod]
        public void CarColorOK()
        {
            clsSstock StockManage = new clsSstock();
            string TestData = "Black";
            StockManage.CarColor = TestData;
            Assert.AreEqual(StockManage.CarColor, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
        }
        [TestMethod]
        public void TestCarIDNoFound()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;

            Boolean OK = true;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
            if (StockManage.CarId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCarBrandNoFound()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;

            Boolean OK = true;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
            if (StockManage.CarBrand != "Test Car Brand")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColorNoFound()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;

            Boolean OK = true;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
            if (StockManage.CarColor != "Test Car Color")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelNoFound()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;

            Boolean OK = true;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
            if (StockManage.CarModel != "Test Car Model")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
            [TestMethod]
            public void TestCarYearNoFound()
            {
                clsSstock StockManage = new clsSstock();
                Boolean Found = false;

                Boolean OK = true;
                Int32 CarID = 2;
                Found = StockManage.Find(CarID);
                if (StockManage.DateAdded != Convert.ToDateTime("17/08/2022"))
                {
                    OK = false;
                }
                Assert.IsTrue(OK);

            }
        [TestMethod]
        public void TestCarAvailableNoFound()
        {
            clsSstock StockManage = new clsSstock();
            Boolean Found = false;

            Boolean OK = true;
            Int32 CarID = 2;
            Found = StockManage.Find(CarID);
            if (StockManage.Active !=  true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandNoMinLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandNoMin()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "a";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandNoMinPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "aa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarBrandNoMaxLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "aaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarBrandNoMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "aaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandNoMid()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "aaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarBrandMaxPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "aaaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandNoExtremeMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarBrand = "";
            CarBrand = CarBrand.PadRight(500, 'a');

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        //
        //
        //
        [TestMethod]
        public void CarModelNoMinLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelNoMin()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "a";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMinPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "aa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMaxLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "aaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "aaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelNoMid()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "aaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelNoMaxPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "aaaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelNoExtremeMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarModel = "";
            CarModel = CarModel.PadRight(500, 'a');
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        //
        //
        //
        [TestMethod]
        public void CarColorNoMinLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarColorMin()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "a";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColorPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "aa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColorMaxLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "aaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColorMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "aaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColorMid()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "aaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColorMaxPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "aaaaaaa";

            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColorExtremeMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string CarColor = "";
            CarColor = CarColor.PadRight(500, 'a');
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        //
        //
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateAdded = TestDate.ToString();
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod] 
        public void DateAddedInvalidData()
        {
            clsSstock StockManage = new clsSstock();
            String Error = "";
            string DateAdded = "This is not a Date!";
            Error = StockManage.Valid(DateAdded, CarModel, CarColor, CarBrand, Active);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddTethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsSstock TestItem = new clsSstock();

            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CarId = 1;
            TestItem.CarBrand = "Mercedes";
            TestItem.CarModel = "E320";
            TestItem.CarColor = "Black";
            TestItem.DateAdded = DateTime.Now.Date;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.CarId = PrimaryKey;
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsSstock TestItem = new clsSstock();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CarId = 1;
            TestItem.CarBrand = "Mercedes";
            TestItem.CarModel = "E320";
            TestItem.CarColor = "Black";
            TestItem.DateAdded = DateTime.Now.Date;
            AllStock.ThisStock = TestItem;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByCarBrandOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByCarBrand("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }
        
        [TestMethod]
        public void ReportByCarBrandNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByCarBrand("Test");
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByCarBrandTestDataFound()
        {
            clsStockCollection FilterStock = new clsStockCollection();
            Boolean OK = true;
            FilterStock.ReportByCarBrand("Some Test");
            if (FilterStock.Count == 2)
            {
               
                if (FilterStock.StockList[0].CarId != 36)
                {
                    OK = false;
                }
                if (FilterStock.StockList[1].CarId != 37)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
    }
