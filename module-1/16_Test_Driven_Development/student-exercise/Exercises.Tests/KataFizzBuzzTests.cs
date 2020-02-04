using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        [DataTestMethod]
        [DataRow(9, "fizz")]
        [DataRow(12, "fizz")]
        [DataRow(24, "fizz")]
        [DataRow(36, "fizz")]
        
        public void fizzBuzzTest(int num, string expected)
        {
            
            KataFizzBuzz fb = new KataFizzBuzz();
            //act
            string result = fb.fizzBuzz(num);


            //assert
            Assert.AreEqual(expected,result);
          
                  


        }

        [DataTestMethod]
        [DataRow(5, "buzz")]
        [DataRow(100, "buzz")]
        [DataRow(25, "buzz")]
        [DataRow(50, "buzz")]


        public void fizzBuzzTest2(int num, string expected)
        {
            KataFizzBuzz fb = new KataFizzBuzz();

            string result = fb.fizzBuzz(num);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(15, "fizzbuzz")]
        [DataRow(30, "fizzbuzz")]
        [DataRow(60, "fizzbuzz")]
        [DataRow(90, "fizzbuzz")]

        public void fizzBuzzTest3(int num, string expected)
        {
            KataFizzBuzz fb = new KataFizzBuzz();
            string result = fb.fizzBuzz(num);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(1, "1")]
        
        [DataRow(98,"98")]
        [DataRow(97, "97")]
        [DataRow(2, "2")]
        [DataRow(4, "4")]

        public void fizzBuzzTest4(int num, string expected)
        {
            KataFizzBuzz fb = new KataFizzBuzz();
            string result = fb.fizzBuzz(num);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(101, "")]
        [DataRow(1000, "")]
        [DataRow(-4,"")]
        public void fizzBuzzTest5(int num, string expected)
        {
            KataFizzBuzz fb = new KataFizzBuzz();
            string result = fb.fizzBuzz(num);
            Assert.AreEqual(expected, result);
        }
    }
   


        //    CollectionAssert.AreEqual(new List<string>() { "1", "2", "Fizz" }, fb.fizzBuzz( 3, 0));
        //CollectionAssert.AreEqual(new List<string>() { "4", "Buzz", "Fizz" }, fb.FizzBuzzList(new int[] { 4, 5, 6 }));
        //CollectionAssert.AreEqual(new List<string>() { "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, fb.FizzBuzzList(new int[] { 7, 8, 9, 10, 11, 12, 13, 14, 15 }));
    }
