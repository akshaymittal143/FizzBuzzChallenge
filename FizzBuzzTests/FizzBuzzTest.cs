using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new FizzBuzzClass();
            result.FizzBuzz(10);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new FizzBuzzClass();
            result.FizzBuzz(100);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new FizzBuzzClass();
            result.FizzBuzz(1000);
        }

    }
}
