using MissingIntegerLibrary;

namespace MissingIntegerTest
{
    [TestClass]
    public class MissingIntegerUnitTest
    {
        [TestMethod]
        public void Prueba136412Regresa5()
        {
            Algoritmo algoritmo = new();
            int[] A_evaluado = {1,3,6,4,1,2};
            int obtenido;
            int esperado = 5;
            obtenido = algoritmo.MissingInt(A_evaluado);
            Assert.AreEqual(obtenido, esperado);    
        }
        [TestMethod]
        public void Prueba123Regresa4()
        {
            Algoritmo algoritmo = new();
            int[] A_evaluado = { 1,2,3 };
            int obtenido;
            int esperado = 4;
            obtenido = algoritmo.MissingInt(A_evaluado);
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void Prueba_1_3Regresa1()
        {
            Algoritmo algoritmo = new();
            int[] A_evaluado = { -1,-3 };
            int obtenido;
            int esperado = 1;
            obtenido = algoritmo.MissingInt(A_evaluado);
            Assert.AreEqual(obtenido, esperado);
        }
    }
}