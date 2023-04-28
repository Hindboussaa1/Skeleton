using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsSstock> TestList = new List<clsSstock>();
            clsSstock TestItem = new clsSstock();
            TestItem.Active = true;
            TestItem.CarId = 1;
            TestItem.CarBrand = "Mercedes";
            TestItem.CarModel = "E320";
            TestItem.CarColor = "Black";
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void CountStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 2;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsSstock TestStock = new clsSstock();
            TestStock.Active = true;
            TestStock.CarId = 1;
            TestStock.CarBrand = "Mercedes";
            TestStock.CarModel = "E320";
            TestStock.CarColor = "Black";
            TestStock.DateAdded = DateTime.Now.Date;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsSstock> TestList = new List<clsSstock>();
            clsSstock TestItem = new clsSstock();
            TestItem.Active = true;
            TestItem.CarId = 1;
            TestItem.CarBrand = "Mercedes";
            TestItem.CarModel = "E320";
            TestItem.CarColor = "Black";
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void UpdateMethodOK()
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

            TestItem.Active = false;
            TestItem.CarId = 21;
            TestItem.CarBrand = "BMW";
            TestItem.CarModel = "M5";
            TestItem.CarColor = "White";
            TestItem.DateAdded = DateTime.Now.Date;
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }
        
       
    }

}
