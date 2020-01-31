using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
   public class WordCountTests
    {
        [TestMethod]

        public void TestBaBa()
        {
            //Arrange
            WordCount wc = new WordCount();
            Dictionary<string, int> expectedResult = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            //Act
            Dictionary<string, int> actualResult = wc.GetCount(new string[] { "ba", "ba", "black", "sheep" });

            //Assert
            CollectionAssert.AreEquivalent
                
                
                (expectedResult, actualResult);

        }
        [TestMethod]

        public void TestBaBa1()
        {
            //Arrange
            WordCount wc = new WordCount();
            Dictionary<string, int> expectedResult = new Dictionary<string, int>()
            {
                {"ra", 1 },
                {"b", 1 },
                {"sleep", 1 }
            };
            //Act
            Dictionary<string, int> actualResult = wc.GetCount(new string[] { "ba", "ba", "black", "sheep" });

            //Assert
            CollectionAssert.AreEquivalent


                (expectedResult, actualResult);

        }

        [TestMethod]

        public void TestBaBa2()
        {
            //Arrange
            WordCount wc = new WordCount();
            Dictionary<string, int> expectedResult = new Dictionary<string, int>()
            {
                {"rachel", 1 },
                {"needs", 1 },
                {"practice", 10 }
            };
            //Act
            Dictionary<string, int> actualResult = wc.GetCount(new string[] { "ba", "ba", "black", "sheep" });

            //Assert
            CollectionAssert.AreEquivalent


                (expectedResult, actualResult);

        }

        [TestMethod]

        public void TestBaBa3()
        {
            //Arrange
            WordCount wc = new WordCount();
            Dictionary<string, int> expectedResult = new Dictionary<string, int>()
            {
                {"Amster",2  },
                {"Dam", 3 },
                
            };
            //Act
            Dictionary<string, int> actualResult = wc.GetCount(new string[] { "ba", "ba", "black", "sheep" });

            //Assert
            CollectionAssert.AreEquivalent


                (expectedResult, actualResult);

        }


    }
}
