using MaxContadoresBiblioteca;

namespace MaxContadoresPruebas
{
    [TestClass]
    public class MaxContadoresUnitTest
    {
        [TestMethod]
        public void Prueba3446144Regresa32242()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo AlgMaxContadores = new();
            int N = 5;
            int[] A_evaluada = {3,4,4,6,1,4,4};
            int[] obtenido;
            int[] esperado = {3,2,2,4,2};
            //Act = Actuar o realizar la prueba unitaria
            obtenido = AlgMaxContadores.ContadorMaximo(N,A_evaluada);
            //Assert = Verificar que la prueba cumplio con la condicion
            CollectionAssert.AreEquivalent(obtenido, esperado);
        }
    }
}