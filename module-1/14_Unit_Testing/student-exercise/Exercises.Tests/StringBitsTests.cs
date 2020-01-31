using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("Rachel", "Rce")]
        [DataRow("Huch", "Hc")]
        [DataRow("Elephant", "Eehn")]
        [DataRow("ok", "o")]


        public void GetBitsTests(string str, string expected)
        {

            StringBits stringBits = new StringBits();

            string result = stringBits.GetBits(str);

            Assert.AreEqual(expected, result);
        }




    }
}
