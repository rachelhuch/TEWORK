using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEndTests
    {
        [DataTestMethod]

        [DataRow(new int[] { 1, 2, 3 }, new int[] {3, 3, 3})]
        [DataRow(new int[] { 11, 5, 9 }, new int [] { 11, 11, 11})]
        [DataRow(new int [] {2, 11, 3 }, new int [] {  3,3,3})]
        [DataRow(new int[] { 5, 7, 1 }, new int [] {5,5,5})]
        [DataRow(new int[] { 0,0,0}, new int[] {0, 0, 0})]
        [DataRow(new int [] {10, 26, 11}, new int [] {11, 11, 11} )]
        //Arrange


    public void MakeArrayTests(int[]nums, int[] expected)
        {
            //Act
            MaxEnd3 maxEnd = new MaxEnd3();
            int[] result = maxEnd.MakeArray(nums);
            CollectionAssert.AreEqual(expected, result);

        }


        //Assert


    }
}
