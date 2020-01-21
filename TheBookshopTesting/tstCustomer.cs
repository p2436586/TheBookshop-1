using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBookshopClasses;

namespace TheBookshopTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void TstCustomerIdOK()
        {

            clsCustomer ACustomerID = new clsCustomer();
            Assert.IsNotNull(ACustomerID);
        }



    }

}
