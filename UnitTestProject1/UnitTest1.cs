using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise_5_3a;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void parseInput_text_Negative1()
        {
            var input = "text";
            var program = new Program();
            var output = program.ParseInput(input);
            Assert.AreEqual(-1, output);
        }

        [TestMethod]
        public void parseInput_number_number()
        {
            var input = "22";
            var program = new Program();
            var output = program.ParseInput(input);
            Assert.AreEqual(22, output);
        }
    }
}
