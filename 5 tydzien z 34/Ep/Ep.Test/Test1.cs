namespace Ep.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestEp1()
        {
            double m = 10;
            double h = 40;
            double g = 10;
            double expected = 4000.00;
            
            double actual = Program.ep(m, h, g);

            Assert.AreEqual(expected, actual);

        }
    }
}
