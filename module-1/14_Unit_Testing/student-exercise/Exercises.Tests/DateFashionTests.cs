using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [DataTestMethod]

        //you, date

        [DataRow (5, 10, 2)]
        [DataRow(5,2,0)]
        [DataRow(5,5,1)]
        [DataRow(8,8,2)]
        [DataRow(8,4,2)]
        [DataRow(8,1,0)]
        [DataRow(1,2,0)]
        [DataRow(4,4,1)]
        [DataRow(0,0,0)]

        public void GetATableTests(int you, int date, int expected)
        {
            DateFashion fashiontests = new DateFashion();
            int result = fashiontests.GetATable(you, date);
            Assert.AreEqual(expected, result);
        }
    }
}
