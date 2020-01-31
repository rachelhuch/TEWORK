using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass]
    public class NonstartTests
    {
        [DataTestMethod]

        [DataRow("Hello", "There", "ellohere")]
        [DataRow("Rachel", "Huch", "acheluch")]
        [DataRow("Ra", "Huch", "auch")]
        [DataRow("Rachels", "Confused", "achelsonfused")]
        [DataRow("Aa", "Schoo", "achoo")]

        public void GetPartialStringTests(string a, string b, string expected)
        {
            NonStart nonStart = new NonStart();

            string result = nonStart.GetPartialString(a, b);

            Assert.AreEqual(expected, result);

        }
    }
}
