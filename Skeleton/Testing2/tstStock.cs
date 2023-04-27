using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
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
    }


}
