using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp.Logic;

namespace TestApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathOperations math = new MathOperations();

            var result = math.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Testsub()
        {
            MathOperations math = new MathOperations();

            var result = math.Sub(2, 1);

            Assert.AreEqual(1, result);
        }
    }
}
