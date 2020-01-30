using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [DataTestMethod]
        //int cigars, bool weekend, actual result
        [DataRow(30, false, false)]

        public void HavePartyTests (int cigars, bool isWeekend, bool expected)
        {
            //class name  variable name = new class name
            CigarParty haveParty = new CigarParty();
            bool result = haveParty.HaveParty(cigars, isWeekend);
            Assert.AreEqual(expected, result);


        }
    }
}
