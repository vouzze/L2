using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test3A
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const int n = 4;
            int[] a = new int[n] { -2, 1, 3, 4 };
            int result_1 = L2Z1.Program.negative(n, a);
            Assert.AreEqual(1, result_1);
            int result_2 = L2Z1.Program.sum_of(n, a);
            Assert.AreEqual(7, result_2);
        }
    }
}
