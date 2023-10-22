using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcClass;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("", true)]
        [DataRow("()", true)]
        [DataRow("(a)", true)]
        [DataRow("(()())", true)]
        [DataRow("(()()a)", true)]
        [DataRow("(()()", false)]
        [DataRow("((((())a))", false)]
        [DataRow("(((())()a)))", false)]
        [DataRow(")(", false)]
        public void ExpressionEvaluator_CheckCurrency_Validate(string expr, bool result)
        {
            Assert.AreEqual(CalcClass.ExpressionEvaluator.CheckCurrency(expr), result);
        }
        [TestMethod]
        [DataRow("1+1", "1 + 1")]
        [DataRow("(1+1)", "(1 + 1)")]
        [DataRow("(        1               +              1              )", "(1 + 1)")]
        [DataRow("(1+-1)", "(1 + 1)")]
        [DataRow("(-1+-1)", "(-1 + 1)")]
        [DataRow("1h1", "")]
        [DataRow("1+", "")]
        public void ExpressionEvaluator_Format_Validate(string expr, string result)
        {
            Assert.AreEqual(CalcClass.ExpressionEvaluator.Format(expr), result);
        }
    }
}
