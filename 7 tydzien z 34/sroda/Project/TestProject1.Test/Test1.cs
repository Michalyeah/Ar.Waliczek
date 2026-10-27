using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] tablica = { 1, 3, 2, 8, 4, 6 };
            int[] actual = Program.Mini(tablica);
        }
    }
}
