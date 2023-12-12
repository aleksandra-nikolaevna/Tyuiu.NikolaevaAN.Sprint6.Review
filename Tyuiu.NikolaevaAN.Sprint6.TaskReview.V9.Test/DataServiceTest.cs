using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint6.TaskReview.V9.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { {9, 81, 5, 25, 10 },
                                            { 7, 49, 2, 4, 9 },
                                            { 2, 4, 0, 0, 8 },
                                            { 10, 100, 0, 0, 2 },
                                            { 2, 4, 0, 0, 2 } };
            int res = ds.resultGetMatrix(array, 0, 10, 0, 1, 3);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
