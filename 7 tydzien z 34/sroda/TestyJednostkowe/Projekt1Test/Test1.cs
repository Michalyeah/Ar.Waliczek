using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestyJednostkowe.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void SortowanieListy_Test()
        {
            //Arrange
            List<int> nieposortowanaLista = new List<int>();
            nieposortowanaLista.Add(1);
            nieposortowanaLista.Add(3);
            nieposortowanaLista.Add(6);
            nieposortowanaLista.Add(5);
            nieposortowanaLista.Add(2);
            nieposortowanaLista.Add(4);
            nieposortowanaLista.Add(7);

            List<int> posortowanaLista = new List<int>();
            posortowanaLista.Add(1);
            posortowanaLista.Add(2);
            posortowanaLista.Add(3);
            posortowanaLista.Add(4);
            posortowanaLista.Add(5);
            posortowanaLista.Add(6);
            posortowanaLista.Add(7);
            //Act
            List<int> actual = Program.SortowanieListy(nieposortowanaLista);

            //Asset
            CollectionAssert.AreEqual(posortowanaLista, actual);
        }
        [TestMethod]
        public void Min_Test()
        {
            //Arrange
            List<int> nieposortowanaLista = new List<int>();
            nieposortowanaLista.Add(1);
            nieposortowanaLista.Add(3);
            nieposortowanaLista.Add(6);
            nieposortowanaLista.Add(5);
            nieposortowanaLista.Add(2);
            nieposortowanaLista.Add(4);
            nieposortowanaLista.Add(7);

            int min = 1;
            //Act
            int actual = Program.Minium(nieposortowanaLista);
            //Asset
            Assert.AreEqual(min, actual);
        }
        [TestMethod]
        public void Max_Test()
        {
            //Arrange
            List<int> nieposortowanaLista = new List<int>();
            nieposortowanaLista.Add(1);
            nieposortowanaLista.Add(3);
            nieposortowanaLista.Add(6);
            nieposortowanaLista.Add(5);
            nieposortowanaLista.Add(2);
            nieposortowanaLista.Add(4);
            nieposortowanaLista.Add(7);

            int maxi = 7;
            //Act
            int actual = Program.Maxium(nieposortowanaLista);
            //Asset
            Assert.AreEqual(maxi, actual);
        }
        [TestMethod]
        public void secondMaxi_Test()
        {
            //Arrange
            List<int> nieposortowanaLista = new List<int>();
            nieposortowanaLista.Add(1);
            nieposortowanaLista.Add(3);
            nieposortowanaLista.Add(6);
            nieposortowanaLista.Add(5);
            nieposortowanaLista.Add(2);
            nieposortowanaLista.Add(4);
            nieposortowanaLista.Add(7);

            int maxi2 = 6;
            //Act
            int actual = Program.secondMaxi(nieposortowanaLista);
            //Asset
            Assert.AreEqual(maxi2, actual);
        }
    }
}
