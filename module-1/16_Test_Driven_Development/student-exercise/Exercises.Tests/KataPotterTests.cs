using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools;


namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {

        
            [DataTestMethod]
            [DataRow(0, 0, 0, 0, 0, 0)]

            public void GetCostTest(int[] books, decimal expectedCost)
            {
                Cart cart = new Cart();
                decimal result = cart.GetCost(books);
                Assert.AreEqual(result, expectedCost);
            }


        }
    }
