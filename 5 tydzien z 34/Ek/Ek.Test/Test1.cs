namespace Ek.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]  //Zawsze trzeba wpisac przed metoda aby testować
        public void TestEk()
        {
            //aaa
            //Arrange
            double m = 15;
            double v = 2;
            double expected = 30.00;
            //Act
            double actual = Program.ek(m,v);

            //Assent
            Assert.AreEqual(expected, actual);
        }
    }
}
