using GeRaQueryLibrary;

namespace GeRaQueryTest
{
    [TestClass]
    public class GeRaQueryUnitTest
    {
        [TestMethod]
        public void PruebaScagcctaP250Q456Regresa241()
        {
            Algoritmo algoritmo = new Algoritmo();
            string S_evaluado = "CAGCCTA";
            int[] P_evaluado = { 2, 5, 0 };
            int[] Q_evaluado = { 4, 5, 6 };
            int[] obtenido;
            int[] esperado = { 2, 4, 1 };
            obtenido = algoritmo.FactMin(S_evaluado,P_evaluado,Q_evaluado);
            CollectionAssert.AreEqual(obtenido, esperado);
        }
    }
}