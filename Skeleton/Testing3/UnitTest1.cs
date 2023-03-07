using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.isNotNull(staff);
        }
    }
}
