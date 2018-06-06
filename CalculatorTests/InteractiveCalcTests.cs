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
    public class InteractiveCalcTests
    {
       
        [TestMethod()]
        public void InteractiveCalcTest()
        {
            string[] args = { "12", "13", ""};
            var target = new InteractiveTesterCalc(new OperationRegistryImpl(), args);
            Assert.AreEqual(target.Compute(), 25);
        }

        [TestMethod()]
        public void InteractiveCalcTestSum()
        {
            string[] args = { "12", "13", "" };
            var target = new InteractiveTesterCalc(new OperationRegistryImpl(), args);
            string[] args1 = { "12", "13", "+" };
            var target1 = new InteractiveTesterCalc(new OperationRegistryImpl(), args1);
            Assert.AreEqual(target.Compute(), target1.Compute());
        }

        [TestMethod()]
        public void InteractiveCalcTestSubtract()
        {
            string[] args = { "9", "25", "-" };
            var target = new InteractiveTesterCalc(new OperationRegistryImpl(), args);
            Assert.AreEqual(target.Compute(), -16);
        }

        [TestMethod()]
        public void InteractiveCalcTestMultuply()
        {
            string[] args = { "45", "13", "*" };
            var target = new InteractiveTesterCalc(new OperationRegistryImpl(), args);
            Assert.AreEqual(target.Compute(), 585);
        }

        [TestMethod()]
        public void InteractiveCalcTestDivide()
        {
            string[] args = { "81", "9", "/" };
            var target = new InteractiveTesterCalc(new OperationRegistryImpl(), args);
            Assert.AreEqual(target.Compute(), 9);
        }

    }

    /// <summary>
    /// Defines a test class for the interactive calculator that simulates user inputs.
    /// </summary>
    class InteractiveTesterCalc : InteractiveCalc {
        private string[] args;
        public InteractiveTesterCalc(IOperationRegistry registry, string[] args) : base(registry)
        {
            this.args = args;
        }

        public override string[] GetArguments()
        {
            return args;
        }
    }
}