using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiplomeProektWPF;

namespace UnitTestProjectTwitter
{
    [TestClass]
    public class TestStringHelper
    {
        public string stringText = "Это несоответствие может создавать дополнительную работу по программированию, приводить к использованию дополнительных переменных для хранения информации о состоянии, применению специальных значений и т.д.";
        public string stringTextCut = "Это несоответствие может создавать дополнительную работу по программированию, приводить к использованию дополнительных переменных для хранен";

        [TestMethod]
        public void TestEmpty()
        {
            var result = StringHelper.Cut(string.Empty, 140);
            Assert.AreEqual(string.Empty, result);
        }
        [TestMethod]
        public void TestString()
        {
            var result = StringHelper.Cut(stringText, 140);
            Assert.AreEqual(stringTextCut, result);
        }
        [TestMethod]
        public void TestNull()
        {
            var result = StringHelper.Cut(null, 140);
            Assert.IsNull(result);
        }
    }
}
