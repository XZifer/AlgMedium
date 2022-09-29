using CountDivLibrary;

namespace CountDivTest
{
    [TestClass]
    public class CountDivUnitTest
    {
        [TestMethod]
        public void PruebaA6B11K2Regresa168()
        {
            Algoritm al = new();
            int A_evaluado = 6;
            int B_evaluado = 11;
            int K_evaluado = 2;
            int[] esperado = { 6,8,10 };
            int[] obtenido;
            obtenido = al.CountDivisible( A_evaluado,B_evaluado,K_evaluado );
            CollectionAssert.AreEqual( esperado, obtenido );
        }
    }
}