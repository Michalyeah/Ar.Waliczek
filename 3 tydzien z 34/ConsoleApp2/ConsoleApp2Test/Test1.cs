namespace ConsoleApp2Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void listaUczniowTest()
        {

            //arrange
            List<string> uczniowie = new List<string>();
            uczniowie.Add("Michał");
            uczniowie.Add("Felipe");
            uczniowie.Add("Karollo");
            uczniowie.Add("Patrykson");
            uczniowie.Add("Kubus");

            List<string> expected = uczniowie;

            List<string> uczniowie1 = new List<string>();
            uczniowie.Add("Michał");
            uczniowie.Add("Felipe");
            uczniowie.Add("Karollo");
            uczniowie.Add("Patrykson");
            uczniowie.Add("Kubus");

            

            //act
            //ConsoleApp2.Program.listaUczniow(uczniowie);

            //assert
            CollectionAssert.AreEqual(uczniowie1, uczniowie);

        }
    }
}
