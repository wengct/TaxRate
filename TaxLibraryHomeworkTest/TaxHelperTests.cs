using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxLibraryHomework;

namespace TaxLibraryHomeworkTest
{

    [TestClass()]
    public class TaxHelperTests
    {

        [TestMethod()]
        public void GetTaxResultTest_Income_100000_Tax_5000()
        {
            decimal income = 100000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 5000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_540000_Tax_27000()
        {
            decimal income = 540000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 27000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_540001_Tax_27000p12()
        {
            decimal income = 540001;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 27000.12m;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_1210000_Tax_107400()
        {
            decimal income = 1210000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 107400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_1218000_Tax_109000()
        {
            decimal income = 1218000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 109000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_2420000_Tax_349400()
        {
            decimal income = 2420000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 349400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_2500000_Tax_373400()
        {
            decimal income = 2500000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 373400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_4530000_Tax_982400()
        {
            decimal income = 4530000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 982400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_5530000_Tax_1382400()
        {
            decimal income = 5530000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 1382400;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetTaxResultTest_Income_10310000_Tax_3294400()
        {
            decimal income = 10310000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 3294400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_10710000_Tax_3494400()
        {
            decimal income = 10710000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 3494400;
            Assert.AreEqual(expected, actual);
        }
    }
}
