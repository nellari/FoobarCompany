using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operations;

namespace Calculator.Tests
{
    [TestClass()]
    public class FileCalcTests
    {

        [TestMethod()]
        public void FileCalcTest()
        {
            var target = new FileCalc("..\\..\\..\\Calculator\\input.txt", new OperationRegistryImpl());
            Assert.AreEqual(target.Compute(), 22);
        }

        [TestMethod()]
        public void FileCalcTestSum()
        {
            var target = new FileCalc("..\\..\\..\\Calculator\\inputSum.txt", new OperationRegistryImpl());
            Assert.AreEqual(target.Compute(), 22);
        }

        [TestMethod()]
        public void FileCalcTestSubtract()
        {
            var target = new FileCalc("..\\..\\..\\Calculator\\inputSubtract.txt", new OperationRegistryImpl());
            Assert.AreEqual(target.Compute(), 12);
        }

        [TestMethod()]
        public void FileCalcTestMultiply()
        {
            var target = new FileCalc("..\\..\\..\\Calculator\\inputMultiply.txt", new OperationRegistryImpl());
            Assert.AreEqual(target.Compute(), 325);
        }

        [TestMethod()]
        public void FileCalcTestDivide()
        {
            var target = new FileCalc("..\\..\\..\\Calculator\\inputDivide.txt", new OperationRegistryImpl());
            Assert.AreEqual(target.Compute(), 1);
        }
    }
}