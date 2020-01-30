using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [DataTestMethod]

        [DataRow("Giraffe", "Tower")]
        [DataRow("LIon", "Pride")]
        [DataRow("DOG", "Pack")]
        [DataRow(" ", "unknown")]

        
        public void AnimalGroupName(string animalName, string expected)
        {
            AnimalGroupName agn = new AnimalGroupName();

            string result = agn.GetHerd(animalName);
            Assert.AreEqual(expected, result);

        }





    }
}
