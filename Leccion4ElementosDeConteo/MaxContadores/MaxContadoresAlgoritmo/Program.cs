using MaxContadoresBiblioteca;

Algoritmo AlgMaxContadores = new();
int N = 5;
int[] A= {3,4,4,6,1,4,4};
int[] obtenido;
int[] esperado = {3,2,2,4,2};
obtenido = AlgMaxContadores.ContadorMaximo(N, A);
Console.WriteLine(obtenido);
Console.WriteLine(esperado);
Console.ReadLine();