using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass]
   public class SameFirstLastTests
    {
        [DataTestMethod]
        [DataRow(new int[]{1, 2, 3}, false)]
        [DataRow(new int[] { 1}, true)]
        [DataRow(new int [] {  100,3, 7, 100}, true)]
        [DataRow(new int [] { 0, 4, 6, 0}, true)]


        public void IsItTheSameTests(int[]nums,  bool expected)
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            bool result = sameFirstLast.IsItTheSame(nums);
            Assert.AreEqual(expected, result);

        }
    }
}
