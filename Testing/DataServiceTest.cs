using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Library;
namespace Testing
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0.00000000000025, 15, 0.00001, 13000000, 11000000, 850, 0.1, 100000);
            double wait = 62.468;
            Assert.AreEqual(wait, res);
        }
    }
}
