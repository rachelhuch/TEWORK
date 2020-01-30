using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]

    public class FrontTimesTests
    {
        [DataTestMethod]

        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Rachel", 5, "RacRacRacRacRac")]
        [DataRow("hi", 4, "hihihihi")]
        [DataRow("Coding", 6, "CodCodCodCodCodCod")]
        [DataRow("ALLCAPS", 1, "ALL")]


        public void frontTimesTests(string str, int n, string expected)
        {
            FrontTimes frontTimes = new FrontTimes();
            string result = frontTimes.GenerateString(str, n);
            Assert.AreEqual(expected, result);
        }

    }
}
