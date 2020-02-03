using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class PotterKata
    {
        [DataTestMethod]
        [DataRow(0, 0, 0, 0,0 ,0)]

        public void GetCostTest(int [] books, decimal expectedCost)
        {
            Cart cart = new Cart();
            decimal result = cart.GetCost(books);
            Assert.AreEqual(result, expectedCost);
        }


    }
}
