using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UchetAvtoTest
{
    [TestClass]
    public class ValidTest
    {

        [TestMethod]
        public void TestTextValid()
        {
            string test1 = UchetAvto.Valid.TextValid("TEST");
            string test2 = UchetAvto.Valid.TextValid("TEST1");
            string test3 = UchetAvto.Valid.TextValid("");
            Assert.AreEqual("TEST", test1);
            Assert.AreEqual(null, test2);
            Assert.AreEqual(null, test3);
        }
        [TestMethod]
        public void TestCheckNumFields()
        {
            string test1 = UchetAvto.Valid.CheckNumFields("1");
            string test2 = UchetAvto.Valid.CheckNumFields("A");
            Assert.AreEqual("1", test1);
            Assert.AreEqual(null, test2);
        }
        [TestMethod]
        public void TestCheckTimeField()
        {
            string test1 = UchetAvto.Valid.CheckTimeField("13");
            string test2 = UchetAvto.Valid.CheckTimeField("13:15");
            Assert.AreEqual(null, test1);
            Assert.AreEqual("13:15", test2);
        }
        [TestMethod]
        public void TestCheckEmail()
        {
            string test1 = UchetAvto.Valid.CheckEmail("asd@asd.df");
            string test2 = UchetAvto.Valid.CheckEmail("sdf");
            Assert.AreEqual("asd@asd.df", test1);
            Assert.AreEqual(null, test2);
        }
        [TestMethod]
        public void TestCheckNewUsername()
        {
            string test1 = UchetAvto.Valid.CheckNewUsername("testuser1");
            string test2 = UchetAvto.Valid.CheckNewUsername("testuser#");
            Assert.AreEqual("testuser1", test1);
            Assert.AreEqual(null, test2);
        }
        [TestMethod]
        public void TestCheckComboBoxValue()
        {
            string test1 = UchetAvto.Valid.CheckComboBoxValue(new string[] { "Test" }, "Test");
            string test2 = UchetAvto.Valid.CheckComboBoxValue(new string[] { "Test" }, "Test1");
            Assert.AreEqual("Test", test1);
            Assert.AreEqual(null, test2);
        }
    }
}
