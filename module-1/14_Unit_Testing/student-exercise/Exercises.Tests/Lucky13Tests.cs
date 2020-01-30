using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]

    
  public  class Lucky13Tests
    {
        [DataTestMethod]

        [DataRow(new int [] {0,2,4}, true)]

        public void GetLuckyTests(int[] nums, bool expected)
        {
            Lucky13 luckyTest = new Lucky13();
            bool result = luckyTest.GetLucky(nums);
            Assert.AreEqual(expected, result);
        }

    }
}
