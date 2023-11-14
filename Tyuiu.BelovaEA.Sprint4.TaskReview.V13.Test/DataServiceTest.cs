using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.TaskReview.V13.Lib;

namespace Tyuiu.BelovaEA.Sprint4.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string a = "123456811";
            int res = ds.Calculate(3, 3, a);
            Assert.AreEqual(4, res);
        }
    }
}
