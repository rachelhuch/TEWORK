using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
  public  class Less20Tests
    {
        [DataTestMethod]

        [DataRow(18, true)]
        [DataRow(2, false)]
        [DataRow(39, true)]
        [DataRow(99, true)]
        [DataRow(30, false)]


        public void Multiple20Tests(int n, bool expected)
        {
            Less20 less20 = new Less20();
            bool result = less20.IsLessThanMultipleOf20(n);
            Assert.AreEqual(expected, result);
        }
    }
}
